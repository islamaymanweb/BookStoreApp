using BookStore.DataAccess.Data;
using BookStore.DataAccess.Repository.IRepsitory;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository
{
    public class CategoryRepository : Repsitory<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;   
        }

        public void Update(Category category)
        {
            _db.categories.Update(category);
        }
    }
}
