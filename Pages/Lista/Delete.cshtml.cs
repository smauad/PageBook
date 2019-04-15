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
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesLista.Models.ListaContext _context;

        public DeleteModel(RazorPagesLista.Models.ListaContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            LISTA = await _context.LISTA.FindAsync(id);

            if (LISTA != null)
            {
                _context.LISTA.Remove(LISTA);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
