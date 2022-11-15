using MichaelsBooks.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MichaelsBooks.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void update(Category category);
    }
}
