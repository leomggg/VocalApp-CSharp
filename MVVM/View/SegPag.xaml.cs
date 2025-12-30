using ProyectoInterfazNatural.MVVM.ViewModel;

namespace ProyectoInterfazNatural.MVVM.View;

public partial class SegPag : ContentPage
{
	VozViewModel vm;
	public SegPag(VozViewModel viewmodel)
	{
		InitializeComponent();
		vm = viewmodel;
		BindingContext = vm;
	}

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}