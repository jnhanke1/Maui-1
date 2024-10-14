using System; 
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Maui.Models; 
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace Maui.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        private readonly UserDbContext _context; 

        [BindProperty] // step 1 on forms - create property in page model. 

        public Username Username{ get; set; } = default!; 

        [BindProperty]
        public Email Email{ get; set; } = default!; 

        [BindProperty]
        public PhoneNumber PhoneNumber {get; set;}  = default!;

        [BindProperty]
        public Device Device {get; set;} = default!;

        [BindProperty]
        public TimeStamp TimeStamp {get; set; } = default!; 

    public IList<User> User {get; set;} = default!; 

    public CreateModel(UserDbContext context, ILogger<CreateModel> logger)
        {
            _context = context; 
            _logger = logger; 
        }
        
        public IActionResult OnPost() //Iaction result - not void, action based on user action.
        {
            if (!ModelState.IsValid)
            {
                return Page(); //if entry/action not valid, simplyl return the page.
            }

            _context.Users.Add(User); //add new info to user db;
            _context.SaveChanges();

            return RedirectToPage("./IndexModel");
        }

    }
}