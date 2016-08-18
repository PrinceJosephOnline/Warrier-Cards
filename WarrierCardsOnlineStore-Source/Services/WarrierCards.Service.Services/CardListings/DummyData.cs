using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarrierCards.Service.DataObjects;

namespace WarrierCards.Service.Services.CardListings
{
    static class DummyData
    {
        internal static List<CardItem> GetDummyData(SearchCriteria criteria)
        {
            List<CardItem> result = new List<CardItem>();
            if (criteria.LowPrice > 0)
            {
                result = Cards.FindAll(c => c.CardSellingPrice >= criteria.LowPrice);
            }

            if (criteria.HighPrice > 0)
            {
                result = Cards.FindAll(c => c.CardSellingPrice <= criteria.HighPrice);
            }

            // TODO: handle criterias, color, religion, etc


            return result.ToList();
        }

        private static string site = "http://localhost:81/Card-Images/";

        static List<CardItem> Cards = new List<CardItem>() 
        { 
            new CardItem() { CardId = 1, CardModelNumber = "Card0", CardName ="Ethnic cards for Hindu wedding" , CardOrginalPrice = 20, CardSellingPrice = 20,
                             CardMainImagePath= site + "1.jpg", IsPortrait = false},

            new CardItem() { CardId = 2, CardModelNumber = "Card1", CardName ="Red and Cream Mix" , CardOrginalPrice = 21, CardSellingPrice = 21,
                            CardMainImagePath= site + "2.jpg", IsPortrait = false},

            new CardItem() { CardId = 3, CardModelNumber = "Card2", CardName ="Ethnic cards Excellency" , CardOrginalPrice = 21, CardSellingPrice = 21,
                CardMainImagePath= site + "3.jpg", IsPortrait = true},

            new CardItem() { CardId = 4, CardModelNumber = "MX012", CardName ="PeaCock Design" , CardOrginalPrice = 15, CardSellingPrice = 14,
                CardMainImagePath= site + "4.jpg", IsPortrait = true},

            new CardItem() { CardId = 5, CardModelNumber = "MX013", CardName ="Sample wedding card 1" , CardOrginalPrice = 100, CardSellingPrice = 99,
                CardMainImagePath= site + "5.jpg", IsPortrait = true},

            new CardItem() { CardId = 6, CardModelNumber = "MX014", CardName ="Sample wedding card 2" , CardOrginalPrice = 100, CardSellingPrice = 99,
                CardMainImagePath= site + "6.jpg", IsPortrait = true},
        };
    }
}