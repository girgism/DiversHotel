using Divers_Hotel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Divers_Hotel.Services.GetTotaPrice
{
    public interface ITotalReservationPrice
    {
        double GetReservationTotal(Reservation reservation);
    }
}
