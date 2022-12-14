using MichaelsBooks.DataAccess.Repository.IRepository;
using MichaelsBooks.Models;
using MichaelsBooks.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MichaelsBooks.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Category category)
        {
            //throw new NotImplementedException();
            //use .NET LINQ to retrieve the first or default category object
            // then pass the id as a generic entity which matters the category ID
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id == category.Id);
            if (objFromDb != null)//Save changes if not null
            {
                objFromDb.Name = category.Name;
                // _db.SaveChanges();
            }
        }
    }
}
