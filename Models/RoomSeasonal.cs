using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Divers_Hotel.Models
{
    public class RoomSeasonal
    {
        [Key]
        [Display(Name = "Room Type ID ")]
        public int RoomId { get; set; }

        [Key]
        [Display(Name = "Season Type ID ")]
        public int SeasonId { get; set; }

        public double Price { get; set; }


        [ForeignKey("RoomId")]
        public RoomType Room { get; set; }

        [ForeignKey("SeasonId")]
        public Season Season { get; set; }

    }
}
