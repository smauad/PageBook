using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesAgenda.Models;

namespace PageBook.Pages.Agenda
{
    public class DeleteModel : PageModel
    {
        private readonly RazorPagesAgenda.Models.AgendaContext _context;

        public DeleteModel(RazorPagesAgenda.Models.AgendaContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            AGENDA = await _context.AGENDA.FindAsync(id);

            if (AGENDA != null)
            {
                _context.AGENDA.Remove(AGENDA);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
