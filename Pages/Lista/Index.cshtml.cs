using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesLista.Models;

namespace PageBook.Pages.Lista
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesLista.Models.ListaContext _context;

        public IndexModel(RazorPagesLista.Models.ListaContext context)
        {
            _context = context;
        }

        public IList<LISTA> LISTA { get;set; }

        public async Task OnGetAsync()
        {
            LISTA = await _context.LISTA.ToListAsync();
        }
    }
}
