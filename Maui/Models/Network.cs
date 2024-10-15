using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR; //required for data validation.

namespace Maui.Models
{
    public class Network
    {
        public int NetID {get; set;} //primary key

        public int BandwidthLimit {get; set;}

        public string SSID {get; set;} = string.Empty;
        
    }
    
}