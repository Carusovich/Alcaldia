using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
   public class UbicacionMapper
    {
        public dtoUbicacion toDto(Ubicacion entity)
        {
            dtoUbicacion dto = new dtoUbicacion();

            return dto{

                id = entity.id,
                latitud = entity.latitud,
                longitud = entity.longitud,
                idZona = entity.idZona,
                
            };

            public Ubicacion toEntity(dtoUbicacion dto)
            {
                Ubicacion entity = new Ubicacion();

                return entity{

                id = dto.idLog,
                latitud = dto.latitud,
                longitud = dto.longitud,
                idZona = dto.idZona,
                
                };




                public List<dtoUbicacion> toDto(List<Ubicacion> colEntity)
                {
                    List<dtoUbicacion> colDto = new List<dtoUbicacion>();

                    foreach (Ubicacion entity in colEntity)
                    {
                        dtoUbicacion dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }
            }
}
