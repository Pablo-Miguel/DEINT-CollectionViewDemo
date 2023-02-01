using DEINT_CollectionViewDemo.MVVM.Models;
using DEINT_CollectionViewDemo.MVVM.ViewModels;

namespace DEINT_CollectionViewDemo.MVVM.Views;

public partial class ProductView : ContentPage
{
	public ProductView()
	{
		InitializeComponent();
		BindingContext = new ProductViewModel();
	}

    private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
		Product productoSeleccionado = e.CurrentSelection[0] as Product;
		if (productoSeleccionado.HasOffer)
		{
			Navigation.PushAsync(new DetalleView(productoSeleccionado));
		}
		else
		{
			DisplayAlert("Productos", "No está en oferta", "OK");
		}
    }
}