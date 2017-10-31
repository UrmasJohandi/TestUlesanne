using System;
using Microsoft.AspNetCore.Mvc;
using TestUlesanne.Models;
using TestUlesanne.Models.ViewModels;
using System.Linq;
using System.Collections.Generic;

namespace TestUlesanne.Controllers
{
    public class SectorController : Controller
    {
        private ISectorRepository sectorRepository;
        private IUserRepository userRepository;
        private IUsersChoiceRepository usersChoiceRepository;

        public SectorController(ISectorRepository _sectorRepo, IUserRepository _userRepo, IUsersChoiceRepository _usersChoiceRepo)
        {
            sectorRepository = _sectorRepo;
            userRepository = _userRepo;
            usersChoiceRepository = _usersChoiceRepo;
        }

        public ViewResult Index(int userId = 0)
        {
            return View(getUsersChoices(userId));
        }

        public UsersChoiceViewModel Save(int userId, string userName, string usersChoices)
        {
            if (userId == 0 && !string.IsNullOrEmpty(userName))
            {
                userId = userRepository.Save(new User { Name = userName });
            }

            var choices = !string.IsNullOrEmpty(usersChoices) ? usersChoices.Split(',') : new string[0];

            var usersChoiceViewModel = new UsersChoiceViewModel
            {
                User = new User
                {
                    Id = userId
                }
            };

            for (var i = 0; i < choices.Length; i++)
            {
                usersChoiceViewModel.UsersChoices.Add(new Sector
                {
                    SectorId = Convert.ToInt32(choices[i])
                });
            }

            usersChoiceRepository.Save(usersChoiceViewModel);

            return getUsersChoices(userId);
        }

        public UsersChoiceViewModel UsersChoicesByName(string userName)
        {
            var userId = 0;

            if (!string.IsNullOrEmpty(userName))
            {
                var user = userRepository.Users.Where(x => x.Name.ToLower().StartsWith(userName.ToLower())).SingleOrDefault();
                userId = user != null ? user.Id : 0;
            }

            return getUsersChoices(userId);
        }

        public List<string> getUsers()
        {
            var usersList = new List<string>();

            foreach (var user in userRepository.Users.OrderBy(x => x.Name))
            {
                usersList.Add(user.Name);
            }

            return usersList;
        }

        private UsersChoiceViewModel getUsersChoices(int userId = 0)
        {
            var sectors = sectorRepository.Sectors.ToList();
            var usersChoices = usersChoiceRepository.UsersChoices.ToList();

            foreach (var sector in sectors)
            {
                if (usersChoices.Where(x => x.UserId == userId && sector.SectorId == x.SectorId).SingleOrDefault() != null)
                {
                    sector.Selected = true;
                }
            }

            var usersChoiceViewModel = new UsersChoiceViewModel
            {
                User = userId != 0 ? userRepository.Users.Where(x => x.Id == userId).SingleOrDefault() : new User(),
                UsersChoices = sectors
            };

            return usersChoiceViewModel;
        }
    }
}
