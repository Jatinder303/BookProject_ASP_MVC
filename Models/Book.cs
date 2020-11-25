using System;
using System.ComponentModel.DataAnnotations;

namespace BookProject_ASP_MVC.Models
{
    public class Book
    {
        [Key]
        public int Book_ID { get; set; }
        public string Book_Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime Date_of_publish { get; set; }
    }
}
