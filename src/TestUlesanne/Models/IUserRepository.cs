using System.Collections.Generic;

namespace TestUlesanne.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> Users { get; }
        int Save(User user);
        void Update(User user);
    }
}
