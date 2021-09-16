using System;
using System.Collections.Generic;
using System.Text;

namespace NationalPark.Models
{
    class Trail
    {

        public int trailId;
        public TrailLevel level;
        
        public Trail(int trailId, TrailLevel level)
        {
            this.trailId = trailId;
            this.level = level;
        }

        public List<HikeReservation> hikeReservations;

        public Trail(int trailId, TrailLevel level, List<HikeReservation> hikeReservations)
        {
            this.trailId = trailId;
            this.level = level;
            this.hikeReservations = hikeReservations;
        }
    }
}