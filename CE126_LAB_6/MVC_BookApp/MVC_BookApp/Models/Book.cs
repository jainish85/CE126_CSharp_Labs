using Microsoft.AspNetCore.Mvc;
using MVC_BookApp.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_BookApp.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public int PublishedYear { get; set; }
    }
}