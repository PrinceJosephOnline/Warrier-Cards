using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WarrierCards.Service.DataObjects;

namespace WarrierCards.Service.Services.CardListings
{
    [ServiceContract]
    public interface IListingService
    {
        [OperationContract]
        List<CardItem> GetCardsList(SearchCriteria searchCriteria);
    }
}
