using System;
using System.Collections.Generic;
using System.Text;

namespace NationalPark.Models
{
    class Person
    {

        public string firstName;
        public string lastName;
        public string workPhone;
        public string homePhone;
        public Role role;
        public List<VehicleRegistration> vehicles;
        public Reservation reservation;
        public Person(string firstName, string lastName, Role role , string workPhone, string homePhone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
            this.workPhone = workPhone;
            this.homePhone = homePhone;
        }

        public Person(string firstName, string lastName, Role role, string workPhone, string homePhone, List<VehicleRegistration> vehicles, Reservation reservation)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.role = role;
            this.workPhone = workPhone;
            this.homePhone = homePhone;
            this.vehicles = vehicles;
            this.reservation = reservation;
        }
        public string getHomePhone()
        {
            if (!string.IsNullOrEmpty(homePhone)) return homePhone;
            return string.Empty;
        }

        public string getWorkPhone()
        {
            if (!string.IsNullOrEmpty(workPhone)) return workPhone;
            return string.Empty;
        }
        
        public int getVehicleCount()
        {
            return vehicles.Count;
        }
    }
}
