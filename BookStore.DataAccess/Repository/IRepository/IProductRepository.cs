using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepsitory
{
    public interface IProductRepository :  IRepsitory<Product>
    {

        void Update(Product Product);
    }
}
