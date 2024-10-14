using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Maui.Models; 

namespace Maui.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly Maui.Models.UserDbContext _context;

        public IndexModel(Maui.Models.UserDbContext context)
        {
            _context = context; 
        }

        public IList<User> User {get; set;} = default!; 

        public async Task OnGetAsync() //populates table, async updates automatically.
        {
            if(_context.Users != null)
            {
                User = await _context.Users.ToListAsync();
            }
        }
    }
}