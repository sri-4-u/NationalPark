using System;
using System.Collections.Generic;
using System.Text;

namespace NationalPark.Models
{
    class HikeReservation
    {
        public int reservationId;
        public bool hasTravelGuide;
        public List<Person> people;
        
        public HikeReservation(int reservationId, List<Person> people, bool hasTravelGuide = false)
        {
            this.reservationId = reservationId;
            this.people = people;
            this.hasTravelGuide = hasTravelGuide;
        }

    }
}
