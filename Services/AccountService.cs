using EN.Web.Models;
using EN.Web.Models.Account;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EN.Web.Services
{
    public interface IAccountService
    {
        User User { get; }
        Task Initialize();
        Task<bool> Login(Login login);
        Task<Login> Rememberedredentials();
        Task Logout();
        Task Register(AddUser model);
        Task<IList<User>> GetAll();
        Task<User> GetById(string id);
        Task Update(string id, EditUser model);
        Task Delete(string id);
    }

    public class AccountService : IAccountService
    {
        private IHttpService _httpService;
        private NavigationManager _navigationManager;
        private ILocalStorageService _localStorageService;
        private string _userKey = "user";

        public User User { get; private set; }

        public AccountService(
            IHttpService httpService,
            NavigationManager navigationManager,
            ILocalStorageService localStorageService
        ) {
            _httpService = httpService;
            _navigationManager = navigationManager;
            _localStorageService = localStorageService;
        }

        public async Task Initialize()
        {
            User = await _localStorageService.GetItem<User>(_userKey);
        }

        public async Task<bool> Login(Login login)
        {
            if (login.Username == "admin" && login.Password == "ENlogin@125")
            {
                User = new User()
                {
                    Username = "admin",
                    Id = "admin",
                    FirstName = "admin",
                    LastName = "admin",
                    Token = "fake-jwt-token"
                };
                await _localStorageService.SetItem(_userKey, User);
                
                if (login.RememberMe)
                {
                    await _localStorageService.SetItem("RememberCredentials", login);
                }
                return true;
            }
            return false;
        }

        public async Task<Login> Rememberedredentials()
        {
            return await _localStorageService.GetItem<Login>("RememberCredentials");
        }

        public async Task Logout()
        {
            User = null;
            await _localStorageService.RemoveItem(_userKey);
            _navigationManager.NavigateTo("account/login");
        }

        public async Task Register(AddUser model)
        {
            await _httpService.Post("/users/register", model);
        }

        public async Task<IList<User>> GetAll()
        {
            return await _httpService.Get<IList<User>>("/users");
        }

        public async Task<User> GetById(string id)
        {
            return await _httpService.Get<User>($"/users/{id}");
        }

        public async Task Update(string id, EditUser model)
        {
            await _httpService.Put($"/users/{id}", model);

            // update stored user if the logged in user updated their own record
            if (id == User.Id) 
            {
                // update local storage
                User.FirstName = model.FirstName;
                User.LastName = model.LastName;
                User.Username = model.Username;
                await _localStorageService.SetItem(_userKey, User);
            }
        }

        public async Task Delete(string id)
        {
            await _httpService.Delete($"/users/{id}");

            // auto logout if the logged in user deleted their own record
            if (id == User.Id)
                await Logout();
        }
    }
}