using System.Security.Cryptography.X509Certificates;

namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }

    public class ServicioDeLimitado
    { 
        public ServicioDeLimitado()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }

    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {
            ObtenerGuid = Guid.NewGuid();
        }

        public Guid ObtenerGuid { get; set; }
    }
}
