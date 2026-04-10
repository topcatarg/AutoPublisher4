namespace AutoPublisher4.Models
{
    public class Publicacion
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Resumen { get; set; } = string.Empty;
        public string Contenido { get; set; } = string.Empty;
        public string Estado { get; set; } = "Borrador";
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        public DateTime? FechaPublicacion { get; set; }

        public Color EstadoColor => Estado switch
        {
            "Publicado" => Color.FromArgb("#1D9E75"),
            "Enviado" => Color.FromArgb("#378ADD"),
            "Error" => Color.FromArgb("#E24B4A"),
            _ => Color.FromArgb("#888780"),
        };
    }
}