using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NationalPark.Models
{
    class Park
    {

        List<CampSite> campSites;
        List<Person> people;
        List<Trail> trails;
        public Park(List<CampSite> campSites , List<Person> people)
        {
            this.campSites = campSites;
            this.people = people;
        }
        public Park(List<CampSite> campSites)
        {
            this.campSites = campSites;
        }

        public Park(List<Trail> trails)
        {
            this.trails = trails;
        }
        public int getTotalCamps()
        {
           return campSites.Count;
        }

        public int getTotalGuests()
        {

            int total = 0;
            foreach(CampSite site in campSites)
            {
                int guestsInSite = site.GetTotalGuests();
                total += guestsInSite;
            }
            return total;
            
        }


        public string getWorkPhoneNumberByLastName(string lastName)
        {
            string result = string.Empty;
            foreach(Person person in people)
            {
                if (person.lastName.ToLower().Equals(lastName.ToLower()) && person.role == Role.RANGER)
                {
                    result = person.getWorkPhone();
                }
            }
            return result;
        }

        public string getHomePhoneNumberByLastName(string lastName)
        {
            string result = string.Empty;
            foreach (Person person in people)
            {
                if (person.lastName.ToLower().Equals(lastName.ToLower()) && person.role == Role.RANGER)
                {
                    result = person.getHomePhone();
                }
            }
            return result;
        }

        

        public List<int> getTrailByLevel(TrailLevel level)
        {
            List<int> list = new List<int>();
            foreach (Trail trail in trails)
            {
                if (trail.level == level)
                {
                    list.Add(trail.trailId);
                }
            }
            return list;
        }

        public Dictionary<TrailLevel, List<int>> getTrailReport()
        {
            Dictionary<TrailLevel, List<int>> keyValuePairs = new Dictionary<TrailLevel, List<int>>();
            foreach(Trail trail in trails)
            {
                if (!keyValuePairs.ContainsKey(trail.level))
                {
                    keyValuePairs.Add(trail.level, new List<int>());
                }
                keyValuePairs[trail.level].Add(trail.trailId);
            }
            return keyValuePairs;
        }

        public string getPopularGuide()
        {
            Dictionary<Person, int> dic = new Dictionary<Person, int>();
            foreach(Trail trail in trails)
            {
                foreach(HikeReservation reservation in trail.hikeReservations)
                {
                    if (reservation.hasTravelGuide)
                    {
                        foreach(Person person in reservation.people)
                        {
                            if(person.role == Role.RANGER)
                            {
                                if (!dic.ContainsKey(person))
                                {
                                    dic.Add(person, 0);
                                }
                                dic[person] += 1;
                            }
                        }
                    }
                }
            }
            Person person1 = dic.Aggregate((x, y) => x.Value > y.Value ? x : y).Key; //LINQ Query to get the ranger with max hike guidances
            return person1.firstName +" "+ person1.lastName; 
        }

        public int getTotalGuestsFromReservations()
        {
            int total = 0;
            foreach (Trail trail in trails)
            {
                foreach (HikeReservation reservation in trail.hikeReservations)
                {
                    
                        foreach (Person person in reservation.people)
                        {
                            if (person.role == Role.GUEST)
                            {
                                total++;
                            }
                        }
                    
                }
            }
            return total;
        }
    }
}
