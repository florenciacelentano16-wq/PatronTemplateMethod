using Dominio;

namespace Aplicacion
{
    public class GestorAventurasService
    {
        public Aventura? CrearAventura(string? opcionAventura)
        {
            return opcionAventura switch
            {
                "1" => new AventuraCueva(),
                "2" => new AventuraRio(),
                _ => null
            };
        }
    }
}
