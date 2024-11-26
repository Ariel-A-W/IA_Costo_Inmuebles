namespace costoinmuebles_backend.Domain.TiposCasas;

public interface ITipoCasa
{
    public IEnumerable<TipoCasa> GetAll();
    public TipoCasa GetById(int id);
}
