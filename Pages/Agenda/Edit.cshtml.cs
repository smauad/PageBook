using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesAgenda.Models;

namespace PageBook.Pages.Agenda
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesAgenda.Models.AgendaContext _context;

        public EditModel(RazorPagesAgenda.Models.AgendaContext context)
        {
            _context = context;
        }

        [BindProperty]
        public AGENDA AGENDA { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AGENDA = await _context.AGENDA.FirstOrDefaultAsync(m => m.ID == id);

            if (AGENDA == null)
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

            _context.Attach(AGENDA).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AGENDAExists(AGENDA.ID))
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

        private bool AGENDAExists(int id)
        {
            return _context.AGENDA.Any(e => e.ID == id);
        }
    }
}
