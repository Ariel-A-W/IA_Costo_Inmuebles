
using System.ComponentModel.DataAnnotations;

namespace costoinmuebles_backend.Application.DTOs.Casas;

public record CasasPredictionRequestDTO
{
    [Required(ErrorMessage = "{0}: Este valor es requerido.")]
    public int UbicacionId { get; set; }

    [Required(ErrorMessage = "{0}: Este valor es requerido.")]
    public int TamanioM2 { get; set; }

    [Required(ErrorMessage = "{0}: Este valor es requerido.")]
    public int Habitaciones { get; set; }

    [Required(ErrorMessage = "{0}: Este valor es requerido.")]
    public int Banios { get; set; }

    [Required(ErrorMessage = "{0}: Este valor es requerido.")]
    public int TipoViviendaId { get; set; }

    [Required(ErrorMessage = "{0}: Este valor es requerido.")]
    public int Antiguedad { get; set; }
}
