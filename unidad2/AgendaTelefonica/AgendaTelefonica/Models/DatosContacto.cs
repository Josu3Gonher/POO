namespace AgendaTelefonica.Models
{
	public class DatosContacto
	{
        public Guid Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? NumeroTelefono { get; set; }
        public TipoTelefono TipoDeTelefono { get; set; }
        public enum TipoTelefono
        {
            Personal,
            Trabajo,
            Casa,
            Otro
        }
    }
}
