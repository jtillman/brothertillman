using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Vue.Net;

namespace BrotherTillman.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IVueEngine _vueEngine;

        public IndexModel(IVueEngine vueEngine)
        {
            _vueEngine = vueEngine;
        }

        public void OnGet()
        {
            _vueEngine.NotifyUsed(_vueEngine.GetComponent("base-page-component"));
            _vueEngine.NotifyUsed(_vueEngine.GetComponent("blog-page-component"));
        }
    }
}
