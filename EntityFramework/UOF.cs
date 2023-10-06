using EntityFramework.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWork;
using UnitOfWork.Interfaces;
using UnitOfWork.Models;

namespace EntityFramework
{
    public class UOF : IUnitOfWork
    {
        public ApplicationDbContext _Context;
        public IBaseRepository<Category> CategoryRepo { get; private set; }

        public IBaseRepository<Item> ItemRepo { get; private set; }

        public IBaseRepository<Order> OrderRepo { get; private set; }

        public IBaseRepository<OrderStatus> OrderStatusRepo { get; private set; }

        public IBaseRepository<Restaurant> RestaurantRepo { get; private set; }

        public IBaseRepository<Review> ReviewRepo { get; private set; }

        public IBaseRepository<Transaction> TransactionRepo { get; private set; }
        public UOF(ApplicationDbContext context)
        {
            _Context = context;
            CategoryRepo = new BaseRepository<Category>(_Context);
            ItemRepo = new BaseRepository<Item>(_Context);
            OrderRepo = new BaseRepository<Order>(_Context);
            OrderStatusRepo = new BaseRepository<OrderStatus>(_Context);
            RestaurantRepo = new BaseRepository<Restaurant>(_Context);
            ReviewRepo = new BaseRepository<Review>(_Context);
            TransactionRepo = new BaseRepository<Transaction>(_Context);
        }
        public int Complete()
        {
            return  _Context.SaveChanges();
        }

        public void  Dispose()
        {
            _Context.Dispose();
        }
    }
}
