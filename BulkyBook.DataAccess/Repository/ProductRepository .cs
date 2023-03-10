using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository: Repository<Product>, IProductRepository
    {
        private  ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            var objFromDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                obj.Title = objFromDb.Title;
                obj.Description = objFromDb.Description;
                obj.Price = objFromDb.Price;
                obj.ISBN= objFromDb.ISBN;
                obj.Author= objFromDb.Author;
                obj.CategoryId= objFromDb.CategoryId;
                obj.CoverTypeId= objFromDb.CoverTypeId;
                obj.Price = objFromDb.Price;
                obj.Price100= objFromDb.Price100;
                obj.Price50= objFromDb.Price50;
                if(obj.ImageUrl != null)
                {
                    obj.ImageUrl=objFromDb.ImageUrl;
                }
            }
        }
    }
}
