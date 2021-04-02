using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using razor_crud.Models;

namespace razor_crud.Pages.Monsters
{
    public class CreateModel : PageModel
    {
        private readonly razor_crudMonsterContext _context;

        public CreateModel(razor_crudMonsterContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Monster Monster { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Monster.Add(Monster);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
