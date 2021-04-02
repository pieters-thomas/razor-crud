using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_crud.Models;

namespace razor_crud.Pages.Monsters
{
    public class IndexModel : PageModel
    {
        private readonly razor_crudMonsterContext _context;

        public IndexModel(razor_crudMonsterContext context)
        {
            _context = context;
        }

        public IList<Monster> Monster { get;set; }

        public async Task OnGetAsync()
        {
            Monster = await _context.Monster.ToListAsync();
        }
    }
}
