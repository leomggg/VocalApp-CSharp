using ProyectoInterfazNatural.MVVM.ViewModel;

namespace ProyectoInterfazNatural.MVVM.View;

public partial class PagPrinc : ContentPage
{
    VozViewModel vm;
	public PagPrinc()
	{
        InitializeComponent();
        vm = new VozViewModel();
        BindingContext = vm;
    }

    private async void IrADictado(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SegPag(vm));
    }
}