using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Divers_Hotel.Models
{
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Guest Name ")]
        public string GuestName { get; set; }

        [Display(Name = "Guest Email ")]
        public string GuestEmail { get; set; }

        [Display(Name = "Guest Country ")]
        public string GuestCountry { get; set; }

        [Display(Name = "Number Of Adults")]
        public int NumberOfAdults { get; set; }

        [Display(Name = "Number Of Childs")]
        public int NumberOfChilds { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name ="Check In")]
        public DateTime CheckIn { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        [Display(Name = "Check Out")]
        public DateTime CheckOut { get; set; }

        [Display(Name ="Total Price")]
        public double TotalPrice { get; set; }
        public int MealId { get; set; }
        public int RoomId { get; set; }

        [ForeignKey("MealId")]
        public  MealType Meal { get; set; }

        [ForeignKey("RoomId")]
        public  RoomType Room { get; set; }

    }
}
