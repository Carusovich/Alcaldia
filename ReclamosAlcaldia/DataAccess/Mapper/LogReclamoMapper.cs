using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class LogReclamoMapper
    {
        public dtoReclamo toDto (LogReclamo entity)
        {
            dtoReclamo dto = new dtoReclamo();

            return dto{

                idLog = entity.idLog,
                estadoLog = entity.estadoLog,
                fechaYhoraLog = entity.fechaYhoraLog,
                observacionesCuadrilla = entity.observacionesCuadrilla,
                comentarioLog = entity.comentarioLog,
                idReclamo = entity.idReclamo,
                nombreDeUsuario = entity.nombreDeUsuario
            };

            public LogReclamo toEntity(dtoLogReclamo dto)
            {
                LogReclamo entity = new LogReclamo();

                return entity{

                idLog = dto.idLog,
                estadoLog = dto.estadoLog,
                fechaYhoraLog = dto.fechaYhoraLog,
                observacionesCuadrilla = dto.observacionesCuadrilla,
                comentarioLog = dto.comentarioLog,
                idReclamo = dto.idReclamo,
                nombreDeUsuario = dto.nombreDeUsuario
                };




                public List<dtoReclamo> toDto(List<LogReclamo> colEntity)
                {
                    List<dtoReclamo> colDto = new List<dtoReclamo>();

                    foreach (LogReclamo entity in colEntity)
                    {
                        dtoReclamo dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }

            }
        }
