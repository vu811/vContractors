using vContractors.Application.Models.Users;
using vContractors.Domain.Entities.Identity;

namespace vContractors.Application.Interfaces;

public interface IUserService
{
    Task<List<User>> GetAll();
    Task<LoginResponse?> LoginAsync(LoginRequest request, string ipAddress);
}
