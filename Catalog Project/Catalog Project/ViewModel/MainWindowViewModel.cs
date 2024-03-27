using Catalog_Project.Common.MVVM;
using Catalog_Project.Logic;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog_Project.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public static CatalogController CatalogController;
        public static MainWindowViewModel Instance;

        public MainWindowViewModel()
        {
            CatalogController = new CatalogController();
            MainWindowViewModel.Instance = this;
            GetManufacturers();
        }

        private void GetManufacturers()
        {
            var temp = MainWindowViewModel.CatalogController.GetManufacturers();
        }
    }
}
