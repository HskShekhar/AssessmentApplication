using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssessmentApplication.Models;

namespace AssessmentApplication.Repository
{
    public interface IUserRepository
    {
        List<User> GetAllUsers();

        User GetUserById(int id);

        User AddUser(User user);

        void DeleteUser(int id);

        void UpdateUser(User user);

    }
}
