namespace Frapi.Source.Container.Interface;
public interface IPublicUserRepository
{
    Task<List<PublicUserModel>> GetAllAsync();
    Task<PublicUserModel?> GetByIdAsync(Guid id);
    Task<List<PublicUserModel>> GetByNameAsync(string name);
    Task<PublicUserModel> CreateAsync(PublicUserModel user);
    Task<bool> UpdateAsync(PublicUserModel user);
    Task<bool> DeleteAsync(Guid id);
}
