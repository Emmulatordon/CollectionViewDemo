﻿using CollectionViewDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionViewDemo.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var product = item as Product;
            if (!product.HasOffer)
            {
                Application.Current.Resources.TryGetValue("ProductsStyle", out var productStyle);
                return productStyle as DataTemplate;
            }
            else
            {
                Application.Current.Resources.TryGetValue("productWithOfferStyle", out var productWithOfferStyle);
                return productWithOfferStyle as DataTemplate;
            }
        }
    }
}
