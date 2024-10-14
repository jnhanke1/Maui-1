using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Maui.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new UserDbContext(
                ServiceProvider.GetRequiredService<DbContextOptions<UserDbContext>>()))
            {
                //look for new users. 
                if (context.Users.Any())
                {
                    return; //DB has been seeded. 
                }

                context.Users.AddRange(
                    new User
                    {
                        UserName = "Elvis Presley", 
                        Email = "elvispresley@test.com", 
                        PhoneNumber = 999-555-1234, 
                        Device = "fdsajkfjdsakljfkds8843279", 
                        TimeStamp = DateTime.Now,
                    }, 
                    new User
                    {
                        UserName = "Billy Joel", 
                        Email = "billyjoel@test.com", 
                        PhoneNumber = 888-559-1586, 
                        Device = "fdsajkfjdsfdsaf54593279", 
                        TimeStamp = DateTime.Now,
                    }, 
                    new User
                    {
                        UserName = "Led Zeppelin", 
                        Email = "zeppy@test.com", 
                        PhoneNumber = 555-888-1458, 
                        Device = "gajoinmwl4838433", 
                        TimeStamp = DateTime.Now,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}