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
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesLista.Models.ListaContext _context;

        public DetailsModel(RazorPagesLista.Models.ListaContext context)
        {
            _context = context;
        }

        public LISTA LISTA { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LISTA = await _context.LISTA.FirstOrDefaultAsync(m => m.ID == id);

            if (LISTA == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
