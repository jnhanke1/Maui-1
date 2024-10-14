using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR; //required for data validation.

namespace Maui.Models
{
    public int PortalID {get; set;} //primary key

    
    [StringLength(255, MinimumLength = 3)]
    public string SplashPageURL { get; set; } = string.Empty; 

    
    [StringLength(500, MinimumLength = 5)]
    public string AuthMethod {get; set;} = string.Empty; 

    
    
}