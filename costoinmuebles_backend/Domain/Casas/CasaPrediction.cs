using Microsoft.ML.Data;

namespace costoinmuebles_backend.Domain.Casas;

public class CasaResponseDTO
{
    [ColumnName("Score")]
    public float Precio { get; set; }
}
