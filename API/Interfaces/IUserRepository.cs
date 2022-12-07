using API.DTOs;
using API.Entities;

namespace API.Interfaces
{
    public interface IUserRepository
    {
        void Update(AppUser user);

        Task<bool> SaveAllAysnc();
        Task<IEnumerable<AppUser>> GetUsersAysnc();

        Task<AppUser> GetUserByIdAysnc(int id);
       
        Task<AppUser> GetUserByUsernameAysnc(string username);

        Task<IEnumerable<MemberDto>> GetMembersAsync();

        Task<MemberDto> GetMemberAsync(string username);
        
    }
}