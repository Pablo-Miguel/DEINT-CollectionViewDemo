using DEINT_CollectionViewDemo.MVVM.Views;

namespace DEINT_CollectionViewDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new ProductView());
	}
}
