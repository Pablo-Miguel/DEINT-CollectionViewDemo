using DEINT_CollectionViewDemo.MVVM.Models;
using DEINT_CollectionViewDemo.MVVM.ViewModels;

namespace DEINT_CollectionViewDemo.MVVM.Views;

public partial class DetalleView : ContentPage
{
	public DetalleView(Product product)
	{
		InitializeComponent();
		BindingContext = new DetalleViewModel(product);
	}
}