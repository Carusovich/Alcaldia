using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
   public class VerticeMapper
    {
        public dtoVertice toDto(Vertice entity)
        {
            dtoVertice dto = new dtoVertice();

            return dto{

                id = entity.id,
                latitud = entity.latitud,
                longitud = entity.longitud,
                idZona = entity.idZona,
                
            };

            public Vertice toEntity(dtoVertice dto)
            {
                Vertice entity = new Vertice();

                return entity{

                id = dto.id,
                latitud = dto.latitud,
                longitud = dto.longitudv,
                idZona = dto.idZona,
                
                };




                public List<dtoVertice> toDto(List<Vertice> colEntity)
                {
                    List<dtoVertice> colDto = new List<dtoVertice>();

                    foreach (Vertice entity in colEntity)
                    {
                        dtoVertice dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }
            }
}
