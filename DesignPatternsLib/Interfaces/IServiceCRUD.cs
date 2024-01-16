namespace DesignPatternsLib.Interfaces;

public interface IServiceCRUD<TipoT>
{
    Task CreateAsync(TipoT entidade);
    Task DeleteAsync(TipoT entidade);
    Task<IEnumerable<TipoT>> GetAsync();
    Task EditAsync(TipoT entidade);
}
