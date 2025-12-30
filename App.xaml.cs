using Microsoft.Extensions.DependencyInjection;
using ProyectoInterfazNatural.MVVM.View;

namespace ProyectoInterfazNatural
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new PagPrinc()));
        }
    }
}