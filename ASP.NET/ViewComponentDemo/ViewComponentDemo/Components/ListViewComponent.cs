using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponentDemo.Components {
    public class ListViewComponent : ViewComponent {

        public async Task<IViewComponentResult> InvokeAsync(string sequencia) {
            var resultado = await Task.FromResult(sequencia.Split(new char[] { ',' }));
            return View(resultado);
        }

    }
}
