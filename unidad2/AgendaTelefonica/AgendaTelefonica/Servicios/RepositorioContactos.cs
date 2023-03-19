using AgendaTelefonica.Interfaces;
using AgendaTelefonica.Models;

namespace AgendaTelefonica.Servicios
{
    public class RepositorioContactos : IRepositorioContactos
    {
        public List<DatosContacto> Contactos { get; set; } = new List<DatosContacto> {};

        public void EditarContacto(DatosContacto datosContacto)
        {
            var contactoModificar =  Contactos.FirstOrDefault(c => c.Id == datosContacto.Id);
            contactoModificar.Nombre = datosContacto.Nombre;
            contactoModificar.Apellido = datosContacto.Apellido;
            contactoModificar.NumeroTelefono = datosContacto.NumeroTelefono;
            contactoModificar.TipoDeTelefono = datosContacto.TipoDeTelefono;
        }

        public DatosContacto ObtenerContacto(Guid id)
        {
            var datosContacto = Contactos.FirstOrDefault(datosContacto => datosContacto.Id == id);
            return datosContacto;
        }

        public List<DatosContacto> ObtenerContactos()
        {
            return Contactos;
        }

        public DatosContacto ObtenerContactos(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
