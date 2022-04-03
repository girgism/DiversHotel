using Divers_Hotel.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Divers_Hotel.Models;
using Divers_Hotel.Services.GetTotaPrice;

namespace Divers_Hotel.Models
{
    public class TotalReservationPrice : ITotalReservationPrice
    {
        private readonly ApplicationDbContext _context;

        public TotalReservationPrice( ApplicationDbContext context)
        {
            _context = context;
        }

        public double GetReservationTotal(Reservation reservation)
        {
            int getNumberOfPersons = (reservation.NumberOfAdults + reservation.NumberOfChilds);

            int numberOfNeededRooms = getNumberOfPersons / 2;

            DateTime checkIn = reservation.CheckIn;
            DateTime checkOut = reservation.CheckOut;

            string daysReserved = (checkOut - checkIn).TotalDays.ToString();
            int numberOfDays = int.Parse(daysReserved);

            var allSeasons = _context.Seasons.ToList();
            var roomSeason = _context.RoomSeasonals.ToList();
            var mealSeason = _context.MealSeasonals.ToList();
            double mealprice = 0;
            double roomprice = 0;

            for (DateTime day = checkIn; day <= checkOut; day=day.AddDays(1.0))
            {
                var isSeason = allSeasons.FirstOrDefault(p => p.StartDate <= day && p.EndDate >= day);

                if (isSeason != null)
                {
                    var isRoomInSeason = roomSeason.FirstOrDefault(r => r.RoomId == reservation.RoomId);
                    var isMealInSeason = mealSeason.FirstOrDefault(m => m.MealId == reservation.MealId);
                   
                    if ( isRoomInSeason != null )
                    {
                        double priceR = roomSeason.Where(r => r.RoomId == reservation.RoomId).FirstOrDefault().Price;
                        roomprice += priceR;
                    }

                    if (isRoomInSeason == null)
                    {
                        double defaultPrice = _context.RoomTypes.Find(reservation.RoomId).RoomPrice;
                        roomprice += defaultPrice;
                    }

                    if (isMealInSeason != null)
                    {
                        double priceM = mealSeason.Where(m => m.MealId == reservation.MealId).FirstOrDefault().Price;
                        mealprice += priceM;
                    }

                    if(isMealInSeason == null)
                    {
                        double defaultPrice = _context.MealTypes.FirstOrDefault(m => m.ID == reservation.MealId).MealPrice;
                        mealprice += defaultPrice;
                    }
                }

                if (isSeason == null)
                {
                    double defaultRoomPrice = _context.RoomTypes.Find(reservation.RoomId).RoomPrice;
                    roomprice += defaultRoomPrice;

                    double defaultMealPrice = _context.MealTypes.FirstOrDefault(m => m.ID == reservation.MealId).MealPrice;
                    mealprice += defaultMealPrice;
                }
            }

            double totalPrice = ((roomprice * numberOfNeededRooms ) + (mealprice * getNumberOfPersons));
            return totalPrice;




            //int seasonID = 0;
            //for (int i = 0; i < _context.Seasons.ToList().Count(); i++)
            //{
            //    DateTime seasonStartDate = _context.Seasons.ToList()[i].StartDate;
            //    DateTime seasonEndDate = _context.Seasons.ToList()[i].EndDate;

            //    if (DateTime.Compare(checkIn, seasonStartDate) >= 0 &&
            //            DateTime.Compare(checkOut, seasonEndDate) >= 0)
            //    {
            //        seasonID = _context.Seasons.ToList()[i].ID;
            //    }
            //    else
            //        seasonID = _context.Seasons.ToList()[i].ID;
            //}


            //int roomID = reservation.RoomId;
            //int mealID = reservation.MealId;

            ////var roomPricePerPerson = _context.RoomSeasonals.Where(e => e.RoomId == roomID && e.SeasonId == seasonID).FirstOrDefault().Price;

            //var roomPricePerPerson = _context.RoomSeasonals.FirstOrDefault(e => e.RoomId == roomID && e.SeasonId == seasonID).Price;


            //var mealPricePerPerson = _context.MealSeasonals.FirstOrDefault(e => e.MealId == mealID && e.SeasonId == seasonID).Price;

            //var totalReservationPrice = ((numberOfDays * (double)roomPricePerPerson * numberOfNeededRooms) + (getNumberOfPersons * (double)mealPricePerPerson * numberOfDays));


            //return (double)totalReservationPrice;

        }


    }
}
