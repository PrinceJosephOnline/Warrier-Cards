using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrierCards.Service.DataObjects;

namespace WarrierCards.Service.Services.Catalogue
{
    public class CatalogueService : ICatalogueService
    {
        public List<CardBasicInfo> GetCardsList(SearchCriteria searchCriteria)
        {
            // TODO: Dummy method here
            return DummyData.GetDummyData(searchCriteria);
        }

        public CardDetails GetCardDetailsById(int cardId)
        {

            return DummyData.GetCardDetailsById(cardId);
        }

        public CardQuickViewData GetCardQuickViewData(int cardId)
        {
            return DummyData.GetCardQuickViewData(cardId);
        }

        public bool SendEnquiry(EnquiryData enquiry)
        {
            return true;
        }

        
    }
}
