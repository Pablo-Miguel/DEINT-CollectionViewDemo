using DEINT_CollectionViewDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_CollectionViewDemo.MVVM.Selectors
{
    public class ProductDataTemplateSelector : DataTemplateSelector
    {
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Product product = (Product) item;
            
            if(!product.HasOffer) {
                Application.Current.Resources.TryGetValue("ProductStyle", out var productStyle);
                return productStyle as DataTemplate;
            }

            Application.Current.Resources.TryGetValue("OfferStyle", out var offerStyle);
            return offerStyle as DataTemplate;
        }
    }
}
