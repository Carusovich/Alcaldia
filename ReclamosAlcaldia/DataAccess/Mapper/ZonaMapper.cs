using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
   public class ZonaMapper
    {
        public dtoZona toDto(Zona entity)
        {
            dtoZona dto = new dtoZona();

            return dto{

                id = entity.id,
                nombre = entity.nombre,
                color = entity.color,
                      
            };

            public Zona toEntity(dtoZona dto)
            {
                Zona entity = new Zona();

                return entity{

                id = dto.id,
                nombre = dto.nombre,
                color = dto.color,
                
                };




                public List<dtoZona> toDto(List<Zona> colEntity)
                {
                    List<dtoZona> colDto = new List<dtoZona>();

                    foreach (Zona entity in colEntity)
                    {
                        dtoZona dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }
            }
}
