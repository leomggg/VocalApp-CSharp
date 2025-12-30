using ProyectoInterfazNatural.MVVM.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace ProyectoInterfazNatural.MVVM.ViewModel
{
    public class VozViewModel : INotifyPropertyChanged
    {
        public Voz mensaje { get; set; } = new Voz();
        
        public ICommand Hablar { get; }

        public VozViewModel()
        {
            Hablar = new Command(async () =>
            {
                if (!string.IsNullOrWhiteSpace(mensaje.Contenido))
                {
                    await TextToSpeech.Default.SpeakAsync(mensaje.Contenido);
                }
            });
        }
       
        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
