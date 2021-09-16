using NationalPark.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NationalPark
{
    static class PopularCampSiteService
    {

        
        public static int getPopularCampSite(List<CampSite> camps)
        {
            CampSite camp = camps[0];
            int popularCampId = camp.id;
            for(int i =1; i < camps.Count; i++)
            {
                if(camp.GetTotalGuests() >= camps[i].GetTotalGuests())
                {
                    popularCampId = camp.id;
                }
                else
                {
                    popularCampId = camps[i].id;
                    camp = camps[i];
                }
            }
            return popularCampId;
            
        }
    }
}
