using Contatos_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Contatos_API.Controllers {
    public class TesteController : Controller {

        string BaseUrl = "https://localhost:44322";

        public IActionResult Index() {
            List<Contato> contatoLista = new List<Contato>();

            using(HttpClient _http = new HttpClient()) {
                _http.BaseAddress = new Uri(BaseUrl);
                MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");

                _http.DefaultRequestHeaders.Accept.Add(contentType);

                HttpResponseMessage response = _http.GetAsync("/api/contatos").Result;

                if(response.IsSuccessStatusCode) {
                    var contatoResponse = response.Content.ReadAsStringAsync().Result;
                    contatoLista = JsonConvert.DeserializeObject<List<Contato>>(contatoResponse);
                }
            }

            return View(contatoLista);
        }

    }
}
