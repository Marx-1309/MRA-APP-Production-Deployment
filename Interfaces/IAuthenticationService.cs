using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleMauiMvvmApp.Interfaces
{
    public interface IAuthenticationService
    {
        Task<AuthResponseModel> Login(LoginModel loginModel);
        Task SetAuthToken();
    }
}
