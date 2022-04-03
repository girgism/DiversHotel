using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Models
{
    public class Season
    {
        [Key]
        [Required]
        public int ID { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
        public DateTime EndDate { get; set; }

        public  ICollection<MealSeasonal> MealSeasonals { get; set; }
        public  ICollection<RoomSeasonal> RoomSeasonals { get; set; }
    }
}
