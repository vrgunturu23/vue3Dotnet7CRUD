using vueCRUDSampleAPI.Entities;
using vueCRUDSampleAPI.Models.Users;

namespace vueCRUDSampleAPI.Services
{
    public interface IUserService
    {
        IEnumerable<vueUser> GetAll();
        vueUser GetById(int id);
        void Create(CreateRequest model);
        void Update(int id, UpdateRequest model);
        void Delete(int id);
    }
}
