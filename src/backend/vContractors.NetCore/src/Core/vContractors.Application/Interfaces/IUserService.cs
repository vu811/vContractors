using vContractors.Domain.Entitties.Identity;

namespace vContractors.Application.Interfaces;

public interface IUserService
{
    Task<List<User>> GetAll();
}
