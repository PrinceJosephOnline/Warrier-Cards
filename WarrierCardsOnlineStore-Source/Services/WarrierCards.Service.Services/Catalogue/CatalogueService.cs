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

        public List<SelectedCardInfo> GetCardsInfoByIds(List<SelectedCard> selectedCards)
        {
            List<SelectedCardInfo> selectedCardInfos = new List<SelectedCardInfo>();
            var selectedCardIds = selectedCards.Select(x => x.CardId);
            var cardBasicInfos = DummyData.Cards.Where(c => selectedCardIds.Contains(c.CardId)).ToList();
            foreach (var card in cardBasicInfos)
            {
                var cardInfo = new SelectedCardInfo();
                cardInfo.Card = card;
                cardInfo.Quantity = selectedCards.Find(c => c.CardId == card.CardId).Quantity;
                selectedCardInfos.Add(cardInfo);
            }

            return selectedCardInfos;
        }

        public bool SendEnquiry(EnquiryData enquiry)
        {
            return true;
        }

        public List<ShippingAddress> GetShippingAddressesByUserId(int userId)
        {
            return null;
        }

        public int SaveShippingAddress(int userId, ShippingAddress address)
        {

            return 1;
        }

        public ShippingAddress GetShippingAddressById(int userId, int shippingId)
        {
            // TODO: make sure address belongs to the user, use userid
            ShippingAddress addr = new ShippingAddress
            {
                RecipientName = "Prince Joseph",
                AddressId = shippingId,
                FullAddress = "test address",
                Mobile = "91-9847399001",
                Landmark = "Landmark1",
                Pincode = "00065",
                Country = "India"
            };
            return addr;
        }

        public OrderSummary GetOrderSummary(int userId, OrderSummaryParams args)
        {
            ShippingAddress addr = GetShippingAddressById(userId, args.ShippingAddressId);
            List<SelectedCardInfo> cardsInfo = GetCardsInfoByIds(args.SelectedCards);
            return DummyOrderSummaryCalculator.GetData(addr, cardsInfo, args);

            //return new OrderSummary();

        }


    }
}
