using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DBFirst.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DBFirst.Pages
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            using (var db = new CursoNetCoreContext())
            {
                var estudantes = db.Estudantes.ToList();
            }
        }
    }
}
