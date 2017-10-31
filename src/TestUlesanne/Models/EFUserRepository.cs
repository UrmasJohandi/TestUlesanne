using System.Collections.Generic;
using System.Linq;

namespace TestUlesanne.Models
{
    public class EFUserRepository : IUserRepository
    {
        private ApplicationDbContext context;
        public EFUserRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<User> Users => context.Users;

        public void Update(User user)
        {
            var dbEntry = context.Users.Where(x => x.Id == user.Id).SingleOrDefault();

            dbEntry.Name = user.Name;

            context.SaveChanges();
        }
        public int Save(User user)
        {
            context.Users.Add(user);

            context.SaveChanges();

            return context.Users.Max(x => x.Id);
        }
    }
}
