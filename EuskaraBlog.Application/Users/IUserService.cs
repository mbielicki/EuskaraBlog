using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EuskaraBlog.Application.Users
{
    public interface IUserService
    {
        Task<bool> IsUserInRoleAsync(Guid userId, string roleName);
    }
}
