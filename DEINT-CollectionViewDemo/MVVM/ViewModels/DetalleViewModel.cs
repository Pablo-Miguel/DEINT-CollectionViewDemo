using DEINT_CollectionViewDemo.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_CollectionViewDemo.MVVM.ViewModels
{
    public class DetalleViewModel
    {
        public Product Producto { get; set; }
        public DetalleViewModel(Product product) {
            Producto = product;
        }
    }
}
