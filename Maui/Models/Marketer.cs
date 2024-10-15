using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR; //required for data validation.

namespace Maui.Models
{
    public class Marketer
    {
    public int TeamID {get; set;} //primary key

    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string TeamName { get; set; } = string.Empty; 


    public int CampaignID {get; set;}

    [StringLength(100, MinimumLength = 7)]
    public string TargetAudience {get; set; } = string.Empty; 

    }
}