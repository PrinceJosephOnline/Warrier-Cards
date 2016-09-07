using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrierCards.Service.DataObjects;

namespace WarrierCards.Service.Services.Catalogue
{
    internal static class DummyOrderSummaryCalculator
    {
        public static OrderSummary GetData(ShippingAddress addr, List<SelectedCardInfo> cardsInfo, OrderSummaryParams args)
        {
            OrderSummary orderSummary = new OrderSummary();
            // Card Cost Calculation
            //************************************************************************************************************
            decimal cardCost = 0;
            double cardWeight = 0;
            double weightBuffer = 100; // packaging
            decimal savings = 0;
            foreach (var card in cardsInfo)
            {
                cardCost += card.Card.CardSellingPrice * card.Quantity;
                cardWeight += card.Card.CardWeight * card.Quantity;

                // Calculate savings, if there is any offer on card
                if (card.Card.CardOrginalPrice > card.Card.CardSellingPrice)
                {
                    savings += (card.Card.CardOrginalPrice - card.Card.CardSellingPrice) * card.Quantity;
                }
            }
            cardWeight += weightBuffer;


            // Shipping Cost Calculation
            //************************************************************************************************************
            //There are nine PIN zones in India, including eight regional zones and 
            //one functional zone (for the Indian Army). The first digit of the PIN code indicates the region. 
            //The second digit indicates the sub-region, and the third digit indicates the sorting district within the region.
            // https://en.wikipedia.org/wiki/Postal_Index_Number
            /*
             *  1 - Delhi, Haryana, Punjab, Himachal Pradesh, Jammu and Kashmir, Chandigarh
                2 - Uttar Pradesh, Uttarakhand
                3 - Rajasthan, Gujarat, Daman and Diu, Dadra and Nagar Haveli
                4 - Goa, Maharashtra, Madhya Pradesh, Chhattisgarh
                5 - Andhra Pradesh, Karnataka, Telangana
                6 - Tamil Nadu, Kerala, Puducherry, Lakshadweep
                7 - Odisha, West Bengal, Arunachal Pradesh, Nagaland, Manipur, Mizoram, Tripura, Meghalaya, Andaman and Nicobar Islands, Assam, Sikkim
                8 - Bihar, Jharkhand
                9 - Army Post office (APO) and Field Post office (FPO) */
            decimal shippingCost = 0;
            decimal southIndiaRatePerKg = 80;
            decimal northIndiaRatePerKg = 90;
            decimal airRatePerKg = 5000;

            decimal cardWeightInKg = Convert.ToDecimal(cardWeight) / 1000;
            // for - Tamil Nadu, Kerala, Puducherry, Lakshadweep
            if (addr.Pincode.StartsWith("6"))
            {
                shippingCost = cardWeightInKg < 2 ? southIndiaRatePerKg : cardWeightInKg * southIndiaRatePerKg;
            }
            else if (addr.Country == "India")
            {
                shippingCost = cardWeightInKg < 2 ? northIndiaRatePerKg : cardWeightInKg * northIndiaRatePerKg;
            }
            else
            {
                shippingCost = cardWeightInKg < 1 ? airRatePerKg : cardWeightInKg * airRatePerKg;
            }

            // Coupon discount Calculation
            //************************************************************************************************************
            string couponCode = args.couponCode;
            decimal discountAmount = 0;
            string message = string.Empty;
            // There can be public coupons (anyone) & exclusive (for a particular user)
            // Verify the validity, including expiry
            if (!string.IsNullOrEmpty(couponCode))
            {
                if (cardCost < 1000)
                { // offer applicable for order above 1000Rs only
                    message = "Coupon valid only for orders above 1000Rs.";
                }
                else
                {
                    if (couponCode.StartsWith("WC100"))
                    {
                        discountAmount = 100;
                    }
                    else if (couponCode.StartsWith("WC"))
                    {
                        discountAmount = 75;
                    }
                    else
                    {
                        message = "Coupon is not valid or expired";
                    }
                }
            }

            // Set the model
            orderSummary.EstimatedTotal = cardCost;
            orderSummary.ShippingWeight = cardWeight / 1000;
            orderSummary.ShippingCost = shippingCost;
            orderSummary.CouponCode = couponCode;
            orderSummary.CouponDiscount = discountAmount;
            orderSummary.CouponError = message;
            orderSummary.TotalSavings = savings + discountAmount;

            return orderSummary;
        }
    }
}
