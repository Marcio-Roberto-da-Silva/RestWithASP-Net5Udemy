using RestWithASPNet5Udemy1.Data.VO;
using RestWithASPNet5Udemy1.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNet5Udemy1.Repository {
    public interface IUserRepository {
        User ValidateCredentials(UserVO user);

        User ValidateCredentials(string username);

        bool RevokeToken(string username);
        User RefreshUserInfo(User user);

    }
}
