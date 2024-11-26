using System.ComponentModel.DataAnnotations;

namespace costoinmuebles_backend.Application.DTOs.Localidades;

public record LocalidadesByIdRequestDTO
{
    [Required(ErrorMessage = "{0}: Este valor es requerido.")]
    public int LocalidadId { get; set; }
}
