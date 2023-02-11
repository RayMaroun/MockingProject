using MockingProject.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingProject.repositories.interfaces
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
    }
}
