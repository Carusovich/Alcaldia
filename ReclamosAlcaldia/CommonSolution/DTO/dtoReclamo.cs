using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonSolution.DTO
{
    public class dtoReclamo
    {
        public int id { get; set; }
        public string estado { get; set; }
        public Nullable<System.DateTime> fechaYhora { get; set; }
        public string observaciones { get; set; }
        public string idCiudadano { get; set; }
        public Nullable<int> idTipoReclamo { get; set; }
        public Nullable<int> idUbicacion { get; set; }
        public Nullable<int> idCuadrilla { get; set; }
    }
}
