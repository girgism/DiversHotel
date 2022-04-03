using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Models
{
    public class MealType
    {
        [Key]
        [Required]
        public int ID { get; set; }

        [Display(Name = "Meal Type Name ")]
        public string Name { get; set; }

        [Display(Name="Out Season Price")]
        public double MealPrice { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        public  ICollection<MealSeasonal> MealSeasonals { get; set; }
    }
}
