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


    }
}
