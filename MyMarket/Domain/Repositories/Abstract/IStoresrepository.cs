using System;
using System.Linq;
using MyMarket.Domain.Entities;

namespace MyMarket.Domain.Repositories.Abstract
{
    public interface IStoresrepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}