namespace TP_Tankopedia_ASP.Services
{
    public interface ITankopediaUsersService
    {
        Task AssignRolesToUser(string email, string role);
    }
}
