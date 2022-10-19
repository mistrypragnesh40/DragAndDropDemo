using DragAndDropDemo.ViewModels;

namespace DragAndDropDemo.Views;

public partial class DashboardView : ContentPage
{
	public DashboardView()
	{
		InitializeComponent();
		this.BindingContext = new DashboardViewModel();
	}
}