using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WarrierCards.Service.DataObjects;

namespace WarrierCards.Service.Services.Catalogue
{
    [ServiceContract]
    public interface ICatalogueService
    {
        [OperationContract]
        List<CardBasicInfo> GetCardsList(SearchCriteria searchCriteria);

        [OperationContract]
        CardDetails GetCardDetailsById(int cardId);

        [OperationContract]
        CardQuickViewData GetCardQuickViewData(int cardId);

        [OperationContract]
        bool SendEnquiry(EnquiryData enquiry);

        // Get by list of card IDs- for short list, cart views

        // Add to short list
        // Add to cart
    }
}
