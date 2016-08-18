using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrierCards.Service.DataObjects;

namespace WarrierCards.Service.Services.CardListings
{
    public class ListingService : IListingService
    {
        public List<CardItem> GetCardsList(SearchCriteria searchCriteria)
        {
            // TODO: Dummy method here
            return DummyData.GetDummyData(searchCriteria);
        }



        
    }
}
