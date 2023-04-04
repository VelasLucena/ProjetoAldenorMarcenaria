namespace AmApi.Models.Interfaces
{
    public interface ILoginService
    {
        Task<bool> Authenticate(string email, string password);

        Task Logout();

        Task<bool> RegisterUser(string email, string password);
    }
}
