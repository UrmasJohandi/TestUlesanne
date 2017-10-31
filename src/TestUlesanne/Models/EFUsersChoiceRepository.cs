using System.Collections.Generic;
using TestUlesanne.Models.ViewModels;
using System.Linq;

namespace TestUlesanne.Models
{
    public class EFUsersChoiceRepository : IUsersChoiceRepository
    {
        private ApplicationDbContext context;
        public EFUsersChoiceRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<UsersChoice> UsersChoices => context.UsersChoices;

        public void Save(UsersChoiceViewModel usersChoiceViewModel)
        {
            var dbEntries = context.UsersChoices.Where(x => x.UserId == usersChoiceViewModel.User.Id).ToList();

            foreach (var userChoice in dbEntries)
            {
                context.UsersChoices.Remove(userChoice);
            }

            context.SaveChanges();

            foreach (var sector in usersChoiceViewModel.UsersChoices)
            {
                context.UsersChoices.Add(new UsersChoice
                {
                    UserId = usersChoiceViewModel.User.Id,
                    SectorId = sector.SectorId
                });
            }

            context.SaveChanges();
        }
    }
}
