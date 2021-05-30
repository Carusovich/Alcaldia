using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapper
{
    public class UsuarioMapper
    {
        public dtoUsuario toDto(Usuario entity)
        {
            dtoUsuario dto = new dtoUsuario();

            return dto{

                nombreDeUsuario = entity.nombreDeUsuario,
                nombre = entity.nombre,
                apellido = entity.apellido,
                contraseña = entity.contraseña,
                telefono = entity.telefono,
                email = entity.email,
                apellido = entity.apellido,
                tipo = entity.tipo,
                
            };

            public Usuario toEntity(dtoUsuario dto)
            {
                Usuario entity = new Usuario();

                return entity{

                nombreDeUsuario = dto.nombreDeUsuario,
                nombre = dto.nombre,
                apellido = dto.apellido,
                contraseña = dto.contraseña,
                telefono = dto.telefono,
                email = dto.email,
                apellido = dto.apellido,
                tipo = dto.tipo,
                
                };




                public List<dtoUsuario> toDto(List<Usuario> colEntity)
                {
                    List<dtoUsuario> colDto = new List<dtoUsuario>();

                    foreach (Usuario entity in colEntity)
                    {
                        dtoUsuario dto = this.toDto(entity);
                        colDto.Add(dto);
                    }

                    return colDto;
                }
            }
}
