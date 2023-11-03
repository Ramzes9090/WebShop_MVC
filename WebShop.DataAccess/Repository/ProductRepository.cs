using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebShop.DataAccess.Data;
using WebShop.DataAccess.Repository.IRepository;
using WebShop.Models;

namespace WebShop.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository 
    {
        private ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            var objFromDB = _db.Products.FirstOrDefault(u=>u.Id == obj.Id);
            if(objFromDB !=null)
            {
                objFromDB.Title = obj.Title;
                objFromDB.Description = obj.Description;
                objFromDB.ISBN = obj.ISBN;
                objFromDB.Author = obj.Author;
                objFromDB.ListPrice = obj.ListPrice;
                objFromDB.Price = obj.Price;
                objFromDB.CategoryId = obj.CategoryId;
                objFromDB.Price50 = obj.Price50;
                objFromDB.Price100 = obj.Price100;
                if(obj.ImageUrl != null)
                {
                    objFromDB.ImageUrl = obj.ImageUrl;  
                }
            }
        }
    }
}
