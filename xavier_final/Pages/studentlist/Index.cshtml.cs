#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using xavier_final.Data;
using xavier_final.prof;

namespace xavier_final.Pages.studentlist
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly xavier_final.Data.xavier_finalContext _context;

        public IndexModel(xavier_final.Data.xavier_finalContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
#pragma warning disable CS8618
#pragma warning disable CS8604
}
