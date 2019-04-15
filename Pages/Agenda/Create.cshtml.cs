using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesAgenda.Models;

namespace PageBook.Pages.Agenda
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesAgenda.Models.AgendaContext _context;

        public CreateModel(RazorPagesAgenda.Models.AgendaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AGENDA AGENDA { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.AGENDA.Add(AGENDA);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}