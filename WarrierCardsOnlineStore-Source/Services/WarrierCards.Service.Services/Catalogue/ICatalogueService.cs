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
        List<SelectedCardInfo> GetCardsInfoByIds(List<SelectedCard> selectedCards);

        [OperationContract]
        bool SendEnquiry(EnquiryData enquiry);

        [OperationContract]
        List<ShippingAddress> GetShippingAddressesByUserId(int userId);

        [OperationContract]
        int SaveShippingAddress(int userId, ShippingAddress address);

        [OperationContract]
        ShippingAddress GetShippingAddressById(int userId, int shippingId);

        [OperationContract]
        OrderSummary GetOrderSummary(int userId, OrderSummaryParams args);

        // Add to short list
        // Add to cart


        //  TODO:
        // Provide list of countries that we support (Clients can use dropdown)
        // Provide list of states in India that we support. (Clients must not use dropdowns, but suggestions can be provided, state can be of any country)
    }
}
