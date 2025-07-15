namespace Frapi.Source.Core.Repository;
public class PublicUserRepository(AppDbContext context) : IPublicUserRepository
{
    #region GetAllAsync
        public async Task<List<PublicUserModel>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }
    #endregion

    #region GetByIdAsync    
        public async Task<PublicUserModel?> GetByIdAsync(Guid id)
        {
            return await context.Users.FindAsync(id);
        }
    #endregion

    #region GetByNameAsync
        public async Task<List<PublicUserModel>> GetByNameAsync(string name)
        {
            return await context.Users
                .Where(u => u.FirstName.ToLower().Contains(name.ToLower()))
                .ToListAsync();
        }
    #endregion

    #region CreateAsync
        public async Task<PublicUserModel> CreateAsync(PublicUserModel user)
        {
            user.Id = Guid.NewGuid();
            context.Users.Add(user);
            await context.SaveChangesAsync();
            return user;
        }
    #endregion

    #region UpdateAsync
        public async Task<bool> UpdateAsync(PublicUserModel user)
        {
            var existing = await context.Users.FindAsync(user.Id);
            if (existing == null) return false;

            existing.FirstName = user.FirstName;
            existing.LastName = user.LastName;
            existing.Email = user.Email;

            await context.SaveChangesAsync();
            return true;
        }
    #endregion

    #region DeleteAsync
        public async Task<bool> DeleteAsync(Guid id)
        {
            var user = await context.Users.FindAsync(id);
            if (user == null) return false;

            context.Users.Remove(user);
            await context.SaveChangesAsync();
            return true;
        }
    #endregion
}
