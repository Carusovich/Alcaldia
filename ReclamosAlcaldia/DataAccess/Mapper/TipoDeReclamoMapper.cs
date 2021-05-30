using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    class TipoDeReclamoMapper
    {
        public dtoTipoDeReclamo toDto(TipoDeReclamo entity)
        {
            dtoTipoDeReclamo dto = new dtoTipoDeReclamo();

            return dto{

                id = entity.id,
                nombre = entity.nombre,
                descripcion = entity.descripcion,
              
            };

            public TipoDeReclamo toEntity(dtoTipoDeReclamo dto)
            {
                TipoDeReclamo entity = new TipoDeReclamo();

                return entity{

                id = dto.idLog,
                nombre = dto.nombre,
                descripcion = dto.descripcion,
               
                };




                public List<dtoTipoDeReclamo> toDto(List<TipoDeReclamo> colEntity)
                {
                    List<dtoTipoDeReclamo> colDto = new List<dtoTipoDeReclamo>();

                    foreach (TipoDeReclamo entity in colEntity)
                    {
                        dtoTipoDeReclamo dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }
            }
}
