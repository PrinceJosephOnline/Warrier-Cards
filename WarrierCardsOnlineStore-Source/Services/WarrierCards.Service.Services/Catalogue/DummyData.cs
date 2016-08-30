using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarrierCards.Service.DataObjects;

namespace WarrierCards.Service.Services.Catalogue
{
    static class DummyData
    {
        internal static List<CardBasicInfo> GetDummyData(SearchCriteria criteria)
        {
            List<CardBasicInfo> result = Cards;
            if (criteria != null && criteria.LowPrice > 0)
            {
                result = Cards.FindAll(c => c.CardSellingPrice >= criteria.LowPrice);
            }

            if (criteria != null && criteria.HighPrice > 0)
            {
                result = Cards.FindAll(c => c.CardSellingPrice <= criteria.HighPrice);
            }

            // TODO: handle criterias, color, religion, etc


            return result.ToList();
        }

        internal static CardDetails GetCardDetailsById(int cardId)
        {
            var cardbasics = DummyData.GetDummyData(null).First(x => x.CardId == cardId);
            var cardDetails = new CardDetails();

            cardDetails.CardId = cardbasics.CardId;
            cardDetails.CardMainImagePath = cardbasics.CardMainImagePath;
            cardDetails.CardModelNumber = cardbasics.CardModelNumber;
            cardDetails.CardName = cardbasics.CardName;
            cardDetails.CardOrginalPrice = cardbasics.CardOrginalPrice;
            cardDetails.CardSellingPrice = cardbasics.CardSellingPrice;
            cardDetails.IsPortrait = cardbasics.IsPortrait;
            List<string> images = new List<string>()
            {
                site + "1/Front of Card with Inserts and Envelope.jpg",
                site + "1/Inserts and Envelope Back.jpg",
                site + "1/Inside Open View of Card with Inserts.jpg",
            };
            cardDetails.CardImages = images;

            return cardDetails;
        }

        internal static CardQuickViewData GetCardQuickViewData(int cardId)
        {
            var cardbasics = DummyData.GetDummyData(null).First(x => x.CardId == cardId);
            var cardQV = new CardQuickViewData();

            cardQV.CardId = cardbasics.CardId;
            cardQV.CardMainImagePath = cardbasics.CardMainImagePath;
            cardQV.CardModelNumber = cardbasics.CardModelNumber;
            cardQV.CardName = cardbasics.CardName;
            cardQV.CardOrginalPrice = cardbasics.CardOrginalPrice;
            cardQV.CardSellingPrice = cardbasics.CardSellingPrice;
            cardQV.IsPortrait = cardbasics.IsPortrait;
            List<string> images = new List<string>()
            {
                site + "1/Front of Card with Inserts and Envelope.jpg",
                site + "1/Inserts and Envelope Back.jpg",
                site + "1/Inside Open View of Card with Inserts.jpg",
            };
            cardQV.CardImages = images;

            return cardQV;
        }

        private static string site = "http://localhost:81/Card-Images/";

        static List<CardBasicInfo> Cards = new List<CardBasicInfo>() 
        { 
            new CardBasicInfo() { CardId = 1, CardModelNumber = "Card0", CardName ="Ethnic cards for Hindu wedding" , CardOrginalPrice = 20, CardSellingPrice = 20,
                             CardMainImagePath= site + "1.jpg", IsPortrait = false},

            new CardBasicInfo() { CardId = 2, CardModelNumber = "Card1", CardName ="Red and Cream Mix" , CardOrginalPrice = 21, CardSellingPrice = 21,
                            CardMainImagePath= site + "2.jpg", IsPortrait = false},

            new CardBasicInfo() { CardId = 3, CardModelNumber = "Card2", CardName ="Ethnic cards Excellency" , CardOrginalPrice = 21, CardSellingPrice = 21,
                CardMainImagePath= site + "3.jpg", IsPortrait = true},

            new CardBasicInfo() { CardId = 4, CardModelNumber = "MX012", CardName ="PeaCock Design" , CardOrginalPrice = 15, CardSellingPrice = 14,
                CardMainImagePath= site + "4.jpg", IsPortrait = true},

            new CardBasicInfo() { CardId = 5, CardModelNumber = "MX013", CardName ="Sample wedding card 1" , CardOrginalPrice = 100, CardSellingPrice = 99,
                CardMainImagePath= site + "5.jpg", IsPortrait = true},

            new CardBasicInfo() { CardId = 6, CardModelNumber = "MX014", CardName ="Sample wedding card 2" , CardOrginalPrice = 100, CardSellingPrice = 99,
                CardMainImagePath= site + "6.jpg", IsPortrait = true},
        };
    }
}