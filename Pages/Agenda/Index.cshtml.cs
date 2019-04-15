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
    public class IndexModel : PageModel
    {
        private readonly RazorPagesAgenda.Models.AgendaContext _context;

        public IndexModel(RazorPagesAgenda.Models.AgendaContext context)
        {
            _context = context;
        }

        public IList<AGENDA> AGENDA { get;set; }

        public async Task OnGetAsync()
        {
            AGENDA = await _context.AGENDA.ToListAsync();
        }
    }
}
