using ProyectoInterfazNatural.MVVM.ViewModel;

namespace ProyectoInterfazNatural.MVVM.View;

/// <summary>
/// Página principal de bienvenida de la aplicación
/// </summary>
public partial class PagPrinc : ContentPage
{
    VozViewModel vm;
	public PagPrinc()
	{
        InitializeComponent();
        vm = new VozViewModel();
        BindingContext = vm;
    }

    /// <summary>
    /// Método para navegar a la página de dictado
    /// </summary>
    private async void IrADictado(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SegPag(vm));
    }
}