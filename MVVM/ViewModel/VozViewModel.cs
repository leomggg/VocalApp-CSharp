using ProyectoInterfazNatural.MVVM.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace ProyectoInterfazNatural.MVVM.ViewModel
{
    public class VozViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Instancia del modelo Voz
        /// </summary>
        public Voz mensaje { get; set; } = new Voz();
        
        /// <summary>
        /// Comando que ejecuta la interfaz natural de voz (Text-To-Speech)
        /// </summary>
        public ICommand Hablar { get; }

        /// <summary>
        /// Inicializa una nueva instancia de la clase VozViewModel
        /// </summary>
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

        /// <summary>
        /// Notifica a la vista cuando una propiedad ha cambiado
        /// </summary>
        /// <param name="nombre"></param>
        public void OnPropertyChanged(string nombre)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nombre));
        }
    }
}
