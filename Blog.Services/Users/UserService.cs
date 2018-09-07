using Blog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog.Repositories;
using Blog.Repositories.Users;

namespace Blog.Services.Users
{
    public class UserService : GenericService<User>, IUserService
    {
        private static IUserRepository _repository;
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public User FindByLoginName(string loginName)
        {
            return _repository.FindByClause(x => x.LoginName == loginName);
        }
    }
}
