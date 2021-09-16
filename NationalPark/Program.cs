using NationalPark.Models;
using System;
using System.Collections.Generic;

namespace NationalPark
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise-1

            Console.WriteLine("---------------------Excercise-1--------------------------------");
            Person p1 = new Person("sri", "tanneru", Role.RANGER, "575757", "373782");
            Person p0 = new Person("Bill", "Smith", Role.RANGER, "7674368323", "111222223");
            Person p2 = new Person("bill", "mason", Role.RANGER, "2122222", "54545544");
            Person p3 = new Person("christine", "stokes", Role.RANGER, "9989999", "0978828");
            List<Person> people = new List<Person>();
            CampSite site1 = new CampSite(1);
            CampSite site2 = new CampSite(2);
            CampSite site3 = new CampSite(3);
            List<CampSite> list1 = new List<CampSite>();
            list1.Add(site1);
            list1.Add(site2);
            list1.Add(site3);
            people.Add(p1);people.Add(p2);people.Add(p3);people.Add(p0);
            Park park = new Park(list1,people);
            Console.WriteLine("Total Guests in the Park - " + park.getTotalCamps());
            Console.WriteLine("Get HomePhoneNumber of Ranger with lastName 'Smith' is - " + park.getHomePhoneNumberByLastName("Smith"));
            Console.WriteLine("Get HomePhoneNumber of Ranger with lastName 'Smith' is - " + park.getWorkPhoneNumberByLastName("Smith"));
            list1 = null;
            people = null;
            park = null;
            Console.WriteLine("---------------------Excercise-2--------------------------------");
            //Exercise-2
            Person p4 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p5 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p6 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p7 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p8 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p9 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p10 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p11 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p12 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p13 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p14 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p15 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            people = new List<Person>();
            people.Add(p4);
            people.Add(p5);
            people.Add(p6);
            people.Add(p7);
            people.Add(p8);
            people.Add(p9);
            people.Add(p10);
            people.Add(p11);
            List<Person> people1 = new List<Person>();
            people1.Add(p12);
            people1.Add(p13);
            List<Person> people2 = new List<Person>();
            people2.Add(p14);
            people2.Add(p15);
            CampSite site4 = new CampSite(1, 10, 0,people1);
            CampSite site5 = new CampSite(2, 12, 0, people2);
            CampSite site6 = new CampSite(3, 13, 0, people);
            list1 = new List<CampSite>();
            list1.Add(site4);
            list1.Add(site5);
            list1.Add(site6);
            Console.WriteLine("Camp with id - " + PopularCampSiteService.getPopularCampSite(list1) + " has the most guests");
            park = new Park(list1);
            Console.WriteLine("Total Guests across the park are - " + park.getTotalGuests());
            Console.WriteLine("------------------Excercise-3------------------------------");


            //Excercise-3
            VehicleRegistration registration1 = new VehicleRegistration("KCSED34");
            VehicleRegistration registration2 = new VehicleRegistration("SSAASS22");
            VehicleRegistration registration3 = new VehicleRegistration("KDJFBVDF");
            VehicleRegistration registration4 = new VehicleRegistration("KJFKTTTT");
            VehicleRegistration registration5 = new VehicleRegistration("PPOJJJII");
            VehicleRegistration registration6 = new VehicleRegistration("OOJJDNUUI");
            VehicleRegistration registration7 = new VehicleRegistration("YYYUUEUEE");
            List<VehicleRegistration> registrations = new List<VehicleRegistration>();
            registrations.Add(registration7);
            registrations.Add(registration6);
            registrations.Add(registration5);
            registrations.Add(registration4);
            List<VehicleRegistration> registrations1 = new List<VehicleRegistration>();
            registrations1.Add(registration3);
            List<VehicleRegistration> registrations2 = new List<VehicleRegistration>();
            registrations2.Add(registration2);
            List<VehicleRegistration> registrations3 = new List<VehicleRegistration>();
            registrations3.Add(registration1);
            Person person = new Person("srinivas", "tanneru", Role.GUEST, "322333",
                "233232", registrations1, Reservation.NEXT_MONTH);
            Person person1 = new Person("Mike", "Kocher", Role.GUEST, "3847755",
                "4554334", registrations2, Reservation.NEXT_MONTH);
            Person person2 = new Person("Ben", "Levine", Role.GUEST, "4354534553",
                "3465655533", registrations, Reservation.CURRENT);
            Person person3 = new Person("Ben", "Fluke", Role.GUEST, "4354534553",
                "3465655533", registrations3, Reservation.NEXT_MONTH);
            List<Person> people3 = new List<Person>();
            people3.Add(person1);
            people3.Add(person);
            people3.Add(person2);
            people3.Add(person3);
            CampSite campSite = new CampSite(1, 20, 0, people3);
            Console.WriteLine("Reservations for next month - " + campSite.getTotalGuestsForNextMonth());
            CampSite campSite1 = new CampSite(2, 14);
            CampSite campSite2 = new CampSite(3, 21);
            Console.WriteLine("Campsite capacity with id 1 is - " + campSite.capacity);
            Console.WriteLine("Campsite capacity with id 2 is - " + campSite1.capacity);
            Console.WriteLine("Campsite capacity with id 3 is - " + campSite2.capacity);

            Console.WriteLine("Remaining capacity of campsite id 1 is - " + campSite.getRemainingCapacity());
            Console.WriteLine("List of vehicles at campsite 1");
            foreach(string str in campSite.getAllVehiclesAtCamp())
            {
                Console.WriteLine("Vehicle Id - " + str);
            }

            Console.WriteLine("---------------Excercise-4--------------------");
            Trail trail = new Trail(1, TrailLevel.ADVANCED);
            Trail trail1 = new Trail(2, TrailLevel.INTERMEDIATE);
            Trail trail2 = new Trail(3, TrailLevel.BEGINNER);
            Trail trail3 = new Trail(4, TrailLevel.BEGINNER);
            Trail trail4 = new Trail(5, TrailLevel.INTERMEDIATE);
            Trail trail5 = new Trail(6, TrailLevel.INTERMEDIATE);
            Trail trail6 = new Trail(7, TrailLevel.ADVANCED);
            Trail trail7 = new Trail(8, TrailLevel.ADVANCED);
            Trail trail8 = new Trail(9, TrailLevel.BEGINNER);
            Trail trail9 = new Trail(10, TrailLevel.BEGINNER);
            Trail trail10 = new Trail(11, TrailLevel.BEGINNER);
            List<Trail> trails = new List<Trail>();
            trails.Add(trail);
            trails.Add(trail1);
            trails.Add(trail2);
            trails.Add(trail3);
            trails.Add(trail4);
            trails.Add(trail5);
            trails.Add(trail6);
            trails.Add(trail7);
            trails.Add(trail8);
            trails.Add(trail9);
            trails.Add(trail10);
            Park park1 = new Park(trails);
            Dictionary<TrailLevel, List<int>> dictionary = park1.getTrailReport();
            foreach(KeyValuePair<TrailLevel, List<int>> entry in dictionary)
            {
                if(entry.Key == TrailLevel.BEGINNER)
                {
                    
                    PrintTrailValues(entry.Key,entry.Value);
                }
                else if (entry.Key == TrailLevel.INTERMEDIATE)
                {
                   
                    PrintTrailValues(entry.Key, entry.Value);
                }
                else if (entry.Key == TrailLevel.ADVANCED)
                {
                    
                    PrintTrailValues(entry.Key, entry.Value);
                }
            }

            TrailLevel level = TrailLevel.INTERMEDIATE;
            List<int> trailList = park1.getTrailByLevel(level);
            PrintTrailValues(level, trailList);

            Console.WriteLine("-------------------Excercise-5--------------------");
            BuildReservation();
        }

        private static void PrintTrailValues(TrailLevel level,List<int> values)
        {
            Console.WriteLine($"Below are the {level} trails");
            foreach (int val in values)
            {
                Console.WriteLine("Trail Id - " + val);
            }
        }

        private static void BuildReservation()
        {
            Person p4 = new Person("bill", "mason", Role.RANGER, "2122222", "54545544");
            Person p5 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p6 = new Person("Chris", "mason", Role.GUEST, "2122222", "54545544");
            Person p7 = new Person("asheley", "stokes", Role.GUEST, "9989999", "0978828");
            Person p8 = new Person("bill", "Lusen", Role.GUEST, "2122222", "54545544");
            Person p9 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p10 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p11 = new Person("mary", "stokes", Role.RANGER, "9989999", "0978828");
            Person p12 = new Person("bill", "mason", Role.RANGER, "2122222", "54545544");
            Person p13 = new Person("christine", "stokes", Role.GUEST, "9989999", "0978828");
            Person p14 = new Person("bill", "mason", Role.GUEST, "2122222", "54545544");
            Person p15 = new Person("christine", "Anderson", Role.GUEST, "9989999", "0978828");
            List<Person> people = new List<Person>();
            people.Add(p4);
            people.Add(p5);
            people.Add(p6);
            HikeReservation hikeReservation = new HikeReservation(1, people, true);

            List<Person> people1 = new List<Person>();
            people1.Add(p12);
            people1.Add(p13);
            people1.Add(p14);
            HikeReservation hikeReservation1 = new HikeReservation(2, people1, true);

            List<Person> people2 = new List<Person>();
            people2.Add(p4);
            people2.Add(p9);
            people2.Add(p10);
            HikeReservation hikeReservation2 = new HikeReservation(3, people2, true);

            List<Person> people3 = new List<Person>();
            people3.Add(p4);
            people3.Add(p7);
            people3.Add(p8);
            HikeReservation hikeReservation3 = new HikeReservation(4, people3, true);

            List<Person> people4 = new List<Person>();
            people4.Add(p15);
            
            HikeReservation hikeReservation4 = new HikeReservation(5, people4, false);
            List<HikeReservation> hikeReservations = new List<HikeReservation>();
            hikeReservations.Add(hikeReservation);
            hikeReservations.Add(hikeReservation4);
            hikeReservations.Add(hikeReservation3);
            hikeReservations.Add(hikeReservation2);
            hikeReservations.Add(hikeReservation1);

            Trail trail = new Trail(1, TrailLevel.INTERMEDIATE, hikeReservations);
            List<Trail> trails = new List<Trail>();
            trails.Add(trail);
            Park park = new Park(trails);

            Console.WriteLine("Most Popular Guide in the park is - " + park.getPopularGuide());
            Console.WriteLine("Total Guests that made reservations to hike is - " + park.getTotalGuestsFromReservations());
        }
    }
}
