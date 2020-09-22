using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkshopBooking.Models
{
    public class VehicleBooking
    {
        public int Id { get; set; }
        [Required, Display(Name = "Client")]
        public string ClientName { get; set; }
        [Required, Display(Name = "Car")]
        public string ModelName { get; set; }
        
        [DataType(DataType.Date), Display(Name = "Booking Date")]
        public DateTime DateOfBooking { get; set; }
        [MaxLength(25), Required]
        public string Notes { get; set; }

    }
}
