using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatukaKabel.Models;

namespace MatukaKabel.Services
{
    public interface IProductsRepository
    {
        Task<ObservableCollection<Product>> LoadProducts();
    }
}
