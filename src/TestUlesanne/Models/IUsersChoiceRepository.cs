using System.Collections.Generic;
using TestUlesanne.Models.ViewModels;

namespace TestUlesanne.Models
{
    public interface IUsersChoiceRepository
    {
        IEnumerable<UsersChoice> UsersChoices { get; }
        void Save(UsersChoiceViewModel usersChoiceViewModel);
    }
}
