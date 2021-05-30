using CommonSolution.DTO;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Mapper
{
   public class CuadrillaMapper
    {
        public dtoCuadrilla toDto (Cuadrilla entity)
        {
            dtoCuadrilla dto = new dtoCuadrilla();

            return dto{ 
            
                id= entity.id,
                nombre = entity.nombre,
                encargado = entity.encargado,
                idZona = entity.idZona,
                cantidadDePeones = entity.cantidadDePeones
            };

            public Cuadrilla toEntity(dtoCuadrilla dto)
            {
                Cuadrilla entity = new Cuadrilla();

                return entity{

                id = dto.id,
                nombre = dto.nombre,
                encargado = dto.encargado,
                idZona = dto.idZona,
                cantidadDePeones = dto.cantidadDePeones

                };




                public List<dtoCuadrilla> toDto(List<Cuadrilla> colEntity)
                {
                    List<dtoCuadrilla> colDto = new List<dtoCuadrilla>();

                    foreach (Cuadrilla entity in colEntity)
                    {
                        dtoCuadrilla dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }

            }
}
