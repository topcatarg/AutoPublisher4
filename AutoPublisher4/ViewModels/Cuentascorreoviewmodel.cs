using System.Collections.ObjectModel;
using System.Windows.Input;

namespace AutoPublisher4.ViewModels
{
    public class CuentasCorreoViewModel : BaseViewModel
    {
        private ObservableCollection<Models.CuentaCorreo> _cuentas = new();

        public ObservableCollection<Models.CuentaCorreo> Cuentas
        {
            get => _cuentas;
            set => SetProperty(ref _cuentas, value);
        }

        public ICommand AgregarCuentaCommand { get; }
        public ICommand EditarCuentaCommand { get; }
        public ICommand EliminarCuentaCommand { get; }

        public CuentasCorreoViewModel()
        {
            AgregarCuentaCommand = new Command(async () => await AgregarCuentaAsync());
            EditarCuentaCommand = new Command<Models.CuentaCorreo>(async (c) => await EditarCuentaAsync(c));
            EliminarCuentaCommand = new Command<Models.CuentaCorreo>(async (c) => await EliminarCuentaAsync(c));
        }

        private async Task AgregarCuentaAsync()
        {
            // TODO: navegar a formulario de nueva cuenta
            await Task.CompletedTask;
        }

        private async Task EditarCuentaAsync(Models.CuentaCorreo? cuenta)
        {
            if (cuenta == null) return;
            // TODO: navegar a formulario de edición
            await Task.CompletedTask;
        }

        private async Task EliminarCuentaAsync(Models.CuentaCorreo? cuenta)
        {
            if (cuenta == null) return;
            // TODO: confirmar y eliminar via repositorio
            Cuentas.Remove(cuenta);
            await Task.CompletedTask;
        }

        public async Task CargarCuentasAsync()
        {
            // TODO: cargar desde SQLite via Dapper
            await Task.CompletedTask;
        }
    }
}