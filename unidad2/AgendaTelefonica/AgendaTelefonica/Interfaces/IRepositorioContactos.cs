using AgendaTelefonica.Models;

namespace AgendaTelefonica.Interfaces
{
    public interface IRepositorioContactos
    {
        List<DatosContacto> ObtenerContactos();
        public DatosContacto ObtenerContactos(Guid id);
        public void EditarContacto(DatosContacto datosContacto);
    }
}
