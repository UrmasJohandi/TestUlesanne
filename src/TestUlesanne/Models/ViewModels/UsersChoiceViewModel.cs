using System.Collections.Generic;

namespace TestUlesanne.Models.ViewModels
{
    public class UsersChoiceViewModel
    {
        public UsersChoiceViewModel()
        {
            UsersChoices = new List<Sector>();
        }
        public User User { get; set; }
        public List<Sector> UsersChoices { get; set; }
    }
}
