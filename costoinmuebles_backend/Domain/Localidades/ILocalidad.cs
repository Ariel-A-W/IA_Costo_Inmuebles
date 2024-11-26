namespace costoinmuebles_backend.Domain.Localidades;

public interface ILocalidad
{
    public IEnumerable<Localidad> GetAll();
    public Localidad GetById(int id);
}
