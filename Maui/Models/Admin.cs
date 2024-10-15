using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.SignalR; //required for data validation.
using System; 
using System.Collections.Generic;

namespace Maui.Models
{
    public class Admin
    {

        public int AdminID {get; set;} //primary key

        public int AdminUsername {get; set;}

        public int AccessLevel {get; set;} = 0;
    }
}