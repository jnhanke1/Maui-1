// using System; 
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using Microsoft.AspNetCore.Mvc.RazorPages;
// using Maui.Models; 
// using Microsoft.AspNetCore.Mvc.Rendering;
// using Maui.Pages;

// namespace Maui.Pages.Users
// {
//     public class CreateModel : PageModel
//     {
//         private readonly Maui.Models.UserDbContext _context;
        
//         private readonly ILogger<CreateModel> _logger;

//         public CreateModel(Maui.Models.UserDbContext context)
//         {
//             _context = context;
//         }

//         public IActionResult OnGet()
//         {
//             return Page();
//         }

//         // [BindProperty] // step 1 on forms - create property in page model. 
//         // public UserName UserName{ get; set; } = default!; 

//         // [BindProperty]
//         // public Email Email{ get; set; } = default!; 

//         // [BindProperty]
//         // public PhoneNumber PhoneNumber {get; set;}  = default!;

//         // [BindProperty]
//         // public Device Device {get; set;} = default!;

//         // [BindProperty]
//         // public TimeStamp TimeStamp {get; set; } = default!; 

//     public IList<User> User {get; set;} = default!; 

//     public CreateModel(UserDbContext context, ILogger<CreateModel> logger)
//         {
//             _context = context; 
//             _logger = logger; 
//         }
        
//         public IActionResult OnPost() //Iaction result - not void, action based on user action.
//         {
//             if (!ModelState.IsValid)
//             {
//                 return Page(); //if entry/action not valid, simplyl return the page.
//             }

//             _context.Users.Add(User); //add new info to user db;
//             _context.SaveChanges();

//             return RedirectToPage("./IndexModel");
//         }

//     }
// }