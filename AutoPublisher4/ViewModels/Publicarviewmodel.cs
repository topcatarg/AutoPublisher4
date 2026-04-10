using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AutoPublisher4.ViewModels
{
    public class PublicarViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Publicacion> _publicacionesDisponibles = new();
        private ObservableCollection<Models.CuentaCorreo> _cuentas = new();
        private Models.Publicacion? _publicacionSeleccionada;

        public ObservableCollection<Models.Publicacion> PublicacionesDisponibles
        {
            get => _publicacionesDisponibles;
            set => SetProperty(ref _publicacionesDisponibles, value);
        }

        public ObservableCollection<Models.CuentaCorreo> Cuentas
        {
            get => _cuentas;
            set => SetProperty(ref _cuentas, value);
        }

        public Models.Publicacion? PublicacionSeleccionada
        {
            get => _publicacionSeleccionada;
            set
            {
                SetProperty(ref _publicacionSeleccionada, value);
                OnPropertyChanged(nameof(PuedePublicar));
            }
        }

        public bool PuedePublicar =>
            PublicacionSeleccionada != null &&
            Cuentas.Any(c => c.Seleccionada);

        public ICommand PublicarCommand { get; }

        public PublicarViewModel()
        {
            PublicarCommand = new Command(async () => await PublicarAsync(), () => PuedePublicar);
        }

        private async Task PublicarAsync()
        {
            // TODO: implementar lógica de envío
            await Task.CompletedTask;
        }
    }
}