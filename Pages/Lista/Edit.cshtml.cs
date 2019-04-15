using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesLista.Models;

namespace PageBook.Pages.Lista
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesLista.Models.ListaContext _context;

        public EditModel(RazorPagesLista.Models.ListaContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(LISTA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LISTAExists(LISTA.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool LISTAExists(int id)
        {
            return _context.LISTA.Any(e => e.ID == id);
        }
    }
}
