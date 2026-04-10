namespace AutoPublisher4.Models
{
    public class CuentaCorreo
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ServidorSmtp { get; set; } = string.Empty;
        public int PuertoSmtp { get; set; } = 587;
        public string Usuario { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool UsaSsl { get; set; } = true;
        public bool Seleccionada { get; set; }

        public string Iniciales
        {
            get
            {
                var partes = Nombre.Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                return partes.Length >= 2
                    ? $"{partes[0][0]}{partes[1][0]}".ToUpper()
                    : Nombre.Length >= 2
                        ? Nombre[..2].ToUpper()
                        : Nombre.ToUpper();
            }
        }
    }
}