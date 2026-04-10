namespace AutoPublisher4.ViewModels
{
    public class ConfiguracionViewModel : BaseViewModel
    {
        private bool _temaOscuro;
        private bool _notificaciones = true;
        private bool _reintentosAutomaticos = true;
        private double _maxReintentos = 3;

        public bool TemaOscuro
        {
            get => _temaOscuro;
            set => SetProperty(ref _temaOscuro, value);
        }

        public bool Notificaciones
        {
            get => _notificaciones;
            set => SetProperty(ref _notificaciones, value);
        }

        public bool ReintentosAutomaticos
        {
            get => _reintentosAutomaticos;
            set => SetProperty(ref _reintentosAutomaticos, value);
        }

        public double MaxReintentos
        {
            get => _maxReintentos;
            set => SetProperty(ref _maxReintentos, value);
        }

        public string Version => AppInfo.Current.VersionString;
    }
}