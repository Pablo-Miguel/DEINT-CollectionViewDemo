using DEINT_CollectionViewDemo.MVVM.ViewModels;

namespace DEINT_CollectionViewDemo.MVVM.Views;

public partial class ProductView : ContentPage
{
	public ProductView()
	{
		InitializeComponent();
		BindingContext = new ProductViewModel();
	}
}