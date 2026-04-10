using System.Windows.Input;

namespace AutoPublisher4.ViewModels
{
    public class HerramientasViewModel : BaseViewModel
    {
        public ICommand ImportarCommand { get; }
        public ICommand ExportarCommand { get; }
        public ICommand LimpiarCacheCommand { get; }
        public ICommand EstadisticasCommand { get; }

        public HerramientasViewModel()
        {
            ImportarCommand = new Command(async () => await ImportarAsync());
            ExportarCommand = new Command(async () => await ExportarAsync());
            LimpiarCacheCommand = new Command(async () => await LimpiarCacheAsync());
            EstadisticasCommand = new Command(async () => await EstadisticasAsync());
        }

        private async Task ImportarAsync() { await Task.CompletedTask; }
        private async Task ExportarAsync() { await Task.CompletedTask; }
        private async Task LimpiarCacheAsync() { await Task.CompletedTask; }
        private async Task EstadisticasAsync() { await Task.CompletedTask; }
    }
}