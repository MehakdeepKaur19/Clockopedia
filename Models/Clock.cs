using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Clockopedia.Models
{
    public class Clock
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Manufacture Date")]
        [DataType(DataType.Date)]
        public DateTime ManufactureDate { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public string Timeformat { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
        public string Warrenty { get; set; }
    }
}