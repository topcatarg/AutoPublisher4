using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AutoPublisher4.ViewModels
{
    public class PublicacionViewModel : BaseViewModel
    {
        private ObservableCollection<Models.Publicacion> _publicaciones = new();

        public ObservableCollection<Models.Publicacion> Publicaciones
        {
            get => _publicaciones;
            set => SetProperty(ref _publicaciones, value);
        }

        public bool HayPublicaciones => Publicaciones.Count > 0;
        public bool NoHayPublicaciones => Publicaciones.Count == 0;

        public ICommand NuevaPublicacionCommand { get; }

        public PublicacionViewModel()
        {
            NuevaPublicacionCommand = new Command(async () => await NuevaPublicacionAsync());
            Publicaciones.CollectionChanged += (s, e) =>
            {
                OnPropertyChanged(nameof(HayPublicaciones));
                OnPropertyChanged(nameof(NoHayPublicaciones));
            };
        }

        private async Task NuevaPublicacionAsync()
        {
            // TODO: navegar a pantalla de nueva publicación
            await Task.CompletedTask;
        }

        public async Task CargarPublicacionesAsync()
        {
            // TODO: cargar desde SQLite via Dapper
            await Task.CompletedTask;
        }
    }
}