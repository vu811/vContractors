using vContractors.Application.Interfaces;
using vContractors.Domain.Entitties.Identity;

namespace vContractors.Application.Services;

public class UserService : IUserService
{
    private readonly IRepository<User> _userRepository;

    public UserService(IRepository<User> userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<User>> GetAll()
    {
       return await _userRepository.GetAllAsync();
    }
}
