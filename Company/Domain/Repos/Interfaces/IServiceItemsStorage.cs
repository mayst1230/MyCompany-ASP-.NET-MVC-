using System;
using System.Linq;
using Company.Domain.Entities;

namespace Company.Domain.Repos.Interfaces
{
    public interface IServiceItemsStorage
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
