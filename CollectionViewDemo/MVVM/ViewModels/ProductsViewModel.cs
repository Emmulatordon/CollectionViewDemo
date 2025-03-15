using CollectionViewDemo.MVVM.Models;
using CollectionViewDemo.MVVM.Services;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectionViewDemo.MVVM.ViewModels
{
    [AddINotifyPropertyChangedInterface]
    public class ProductsViewModel
    {
        public ObservableCollection<Product> Products { get; set; } = new();
        public bool IsRefreshing { get; set; }
        public ICommand RefreshCommand => new Command
            (async () =>
            {
                IsRefreshing = true;
                await Task.Delay(4000);
                RefreshItems();
                IsRefreshing = false;

            });
        public ICommand ThresholdReachCommand => new Command
            (async () =>
            {
                RefreshItems(Products.Count);
            });
        public ICommand DeleteCommand => new Command((p) =>
        {
            Products.Remove((Product)p);
        });
        public ProductsViewModel()
        {
             RefreshItems();
        }

        private void  RefreshItems(int lastIndex = 0)
        {
            int numberOfItemsPerPage = 10;
            var items = ProductService.GetProducts();
            var pagedProducts = items.Skip(lastIndex).Take(numberOfItemsPerPage);
            foreach (var product in pagedProducts)
            {
                Products.Add(product);
            }
        }
    }
}
