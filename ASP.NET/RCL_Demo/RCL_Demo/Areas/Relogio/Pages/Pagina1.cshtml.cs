using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RCL_Demo.MyFeature.Pages {
    public class Page1Model : PageModel {
        public void OnGet() {
            TempData["Horario"] = DateTime.Now;
            TempData["Usuario"] = "Caio";
        }
    }
}
