using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesLista.Models;

namespace PageBook.Pages.Lista
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesLista.Models.ListaContext _context;

        public CreateModel(RazorPagesLista.Models.ListaContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public LISTA LISTA { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.LISTA.Add(LISTA);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}