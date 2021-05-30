using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class ReclamoMapper
    {
        public dtoReclamo toDto(LogReclamo entity)
        {
            dtoReclamo dto = new dtoReclamo();

            return dto{

                id = entity.id,
                estado = entity.estado,
                fechaYhora = entity.fechaYhora,
                observaciones = entity.observaciones,
                idCiudadano = entity.idCiudadano,
                idTipoReclamo = entity.idTipoReclamo,
                idUbicacion = entity.idUbicacion,
                idCuadrilla = entity.idCuadrilla
            };

            public Reclamo toEntity(dtoReclamo dto)
            {
                Reclamo entity = new Reclamo();

                return entity{

                id = dto.id,
                estado = dto.estado,
                fechaYhora = dto.fechaYhora,
                observaciones = dto.observaciones,
                idCiudadano = dto.idCiudadano,
                idTipoReclamo = dto.idTipoReclamo,
                idUbicacion = dto.idUbicacion,
                idCuadrilla = dto.idCuadrilla
                };




                public List<dtoReclamo> toDto(List<Reclamo> colEntity)
                {
                    List<dtoReclamo> colDto = new List<dtoReclamo>();

                    foreach (Reclamo entity in colEntity)
                    {
                        dtoReclamo dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }
            }
}
