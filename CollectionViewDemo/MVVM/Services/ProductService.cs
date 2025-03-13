using CollectionViewDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo.MVVM.Services
{
    public static class ProductService
    {
        public static ObservableCollection<Product> GetProducts()
        {
            return new ObservableCollection<Product>
        {
            new Product { Name = "Laptop", Price = 1200m, Image = "alcohol.png", HasOffer = true, OfferPrice = 999m },
            new Product { Name = "Smartphone", Price = 800m, Image = "apple.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Headphones", Price = 150m, Image = "banana.png", HasOffer = true, OfferPrice = 120m },
            new Product { Name = "Smartwatch", Price = 300m, Image = "bread.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Tablet", Price = 600m, Image = "cake.png", HasOffer = true, OfferPrice = 550m },
            new Product { Name = "Monitor", Price = 250m, Image = "candy.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Keyboard", Price = 80m, Image = "carrot.png", HasOffer = true, OfferPrice = 65m },
            new Product { Name = "Mouse", Price = 50m, Image = "cheese.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Speaker", Price = 200m, Image = "cream.png", HasOffer = true, OfferPrice = 180m },
            new Product { Name = "External Hard Drive", Price = 150m, Image = "cucumber.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Gaming Console", Price = 500m, Image = "eggs.png", HasOffer = true, OfferPrice = 450m },
            new Product { Name = "Webcam", Price = 100m, Image = "fish.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Microphone", Price = 130m, Image = "flour.png", HasOffer = true, OfferPrice = 110m },
            new Product { Name = "Graphics Card", Price = 700m, Image = "ham.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Processor", Price = 400m, Image = "ice.png", HasOffer = true, OfferPrice = 350m },
            new Product { Name = "RAM 16GB", Price = 90m, Image = "juice.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Power Bank", Price = 60m, Image = "pasta.png", HasOffer = true, OfferPrice = 50m },
            new Product { Name = "Router", Price = 120m, Image = "peas.png", HasOffer = false, OfferPrice = 0m },
            new Product { Name = "Projector", Price = 450m, Image = "pepper.png", HasOffer = true, OfferPrice = 400m },
            new Product { Name = "VR Headset", Price = 600m, Image = "rice.png", HasOffer = false, OfferPrice = 0m }
        };
        }
    }
}
