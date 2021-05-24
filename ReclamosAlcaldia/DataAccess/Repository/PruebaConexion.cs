using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repository
{
    public class PruebaConexion
    {

        public void AgregarTipoReclamo()
        {
            using (ReclamosAlcaldiaEntities context = new ReclamosAlcaldiaEntities())
            {
                TipoDeReclamo nuevoTipoReclamo = new TipoDeReclamo();

                nuevoTipoReclamo.nombre = "tipoRecPueba";
                nuevoTipoReclamo.descripcion = "descripcion";
                context.TipoDeReclamo.Add(nuevoTipoReclamo);
                context.SaveChanges();
            }
        }


    }
}
