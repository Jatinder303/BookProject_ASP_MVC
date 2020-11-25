using System;
using System.ComponentModel.DataAnnotations;

namespace BookProject_ASP_MVC.Models
{
    public class Rental
    {
        [Key]
        public int Rental_ID { get; set; }

        public int Cust_ID { get; set; }
        public Customer Customer { get; set; }

        public int Book_ID { get; set; }
        public Book Book { get; set; }

        public DateTime IssueDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
