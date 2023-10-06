using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork.Interfaces;
using UnitOfWork.Models;

namespace UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<Category> CategoryRepo { get; }
        IBaseRepository<Item> ItemRepo { get; }
        IBaseRepository<Order> OrderRepo { get; }
        IBaseRepository<OrderStatus> OrderStatusRepo { get; }
        IBaseRepository<Restaurant> RestaurantRepo { get; }
        IBaseRepository<Review> ReviewRepo { get; }
        IBaseRepository<Transaction> TransactionRepo { get; }
        int Complete();
    }
}
