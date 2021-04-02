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
    public class DetailsModel : PageModel
    {
        private readonly razor_crudSpellContext _context;

        public DetailsModel(razor_crudSpellContext context)
        {
            _context = context;
        }

        public Spell Spell { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Spell = await _context.Spell.FirstOrDefaultAsync(m => m.ID == id);

            if (Spell == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
