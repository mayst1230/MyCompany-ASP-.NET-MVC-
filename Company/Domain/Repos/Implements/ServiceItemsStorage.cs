using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Company.Domain.Entities;
using Company.Domain.Repos.Interfaces;

namespace Company.Domain.Repos.Implements
{
    public class ServiceItemsStorage : IServiceItemsStorage
    {
        private readonly MyCompanyDatabaseContext context;

        public ServiceItemsStorage(MyCompanyDatabaseContext context)
        {
            this.context = context;
        }

        public IQueryable<ServiceItem> GetServiceItems()
        {
            return context.ServiceItems;
        }

        public ServiceItem GetServiceItemById(Guid id)
        {
            return context.ServiceItems.FirstOrDefault(x => x.Id == id);
        }

        public void SaveServiceItem(ServiceItem entity)
        {
            if (entity.Id == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void DeleteServiceItem(Guid id)
        {
            context.ServiceItems.Remove(new ServiceItem() { Id = id });
            context.SaveChanges();
        }
    }
}
