using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using razor_crud.Models;

namespace razor_crud.Pages.Spells
{
    public class IndexModel : PageModel
    {
        private readonly razor_crudSpellContext _context;

        public IndexModel(razor_crudSpellContext context)
        {
            _context = context;
        }

        public IList<Spell> Spell { get;set; }

        public async Task OnGetAsync()
        {
            Spell = await _context.Spell.ToListAsync();
        }
    }
}
