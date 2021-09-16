using System;
using System.Collections.Generic;
using System.Text;

namespace NationalPark.Models
{
    class CampSite
    {

        public int id;
        public int capacity;
        public int numOfVehicles;
        public List<Person> people = new List<Person>();

        public CampSite(int id, int capacity)
        {
            this.id = id;
            this.capacity = capacity;
        }
        public CampSite(int id, int capacity, int numOfVehicles, List<Person> people)
        {
            this.id = id;
            this.capacity = capacity;
            this.numOfVehicles = numOfVehicles;
            this.people = people;
        }
        public int GetTotalGuests()
        {
            int total = 0;
            foreach(Person p in people)
            {
                if(p.role == Role.GUEST)
                {
                    total++;
                }
            }
            return total;
        }

        public int GetTotalRangers()
        {
            int total = 0;
            foreach (Person p in people)
            {
                if (p.role == Role.RANGER)
                {
                    total++;
                }
            }
            return total;
        }

        public CampSite(int id)
        {
            this.id = id;
        }


        public int getTotalGuestsForNextMonth()
        {
            int total = 0;
            foreach(Person p in people)
            {
                if(p.role == Role.GUEST && p.reservation == Reservation.NEXT_MONTH)
                {
                    total++;
                }
            }
            return total;
        }

        public int getRemainingCapacity()
        {
            int total = 0;
            foreach(Person person in people)
            {
                if(person.reservation == Reservation.CURRENT)
                {
                    total += person.getVehicleCount();
                }
            }
            return capacity - total;
        }

        public List<string> getAllVehiclesAtCamp()
        {
            List<string> result = new List<string>();
            foreach(Person p in people)
            {
                if(p.role == Role.GUEST && p.reservation == Reservation.CURRENT)
                {
                    foreach(VehicleRegistration r in p.vehicles)
                    {
                        result.Add(r.vehicleId);
                    }
                }
            }
            return result;
        }
       
    }
}
