using System;
using System.ComponentModel.DataAnnotations;

namespace BookProject_ASP_MVC.Models
{
    public class Customer
    {
        [Key]
        public int Cust_ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
    }
}
