using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR; //required for data validation.

namespace Maui.Models
{
    public class User{
        public int UserID {get; set;} //primary key

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string UserName { get; set; } = string.Empty; 

        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Email {get; set;} = string.Empty; 

        [StringLength(20, MinimumLength = 7)]
        public string PhoneNumber {get; set; } = string.Empty; 

        public string Device {get; set;} = string.Empty; 

        public DateTime TimeStamp {get; set;} = DateTime.Now; 
        
    }
}