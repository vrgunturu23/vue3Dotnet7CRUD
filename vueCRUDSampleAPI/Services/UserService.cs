using AutoMapper;
using vueCRUDSampleAPI.Entities;
using vueCRUDSampleAPI.Helpers;
using vueCRUDSampleAPI.Models.Users;

namespace vueCRUDSampleAPI.Services
{
    public class UserService : IUserService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public UserService(
            DataContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public IEnumerable<vueUser> GetAll()
        {
            return _context.vueUsers;
        }

        public vueUser GetById(int id)
        {
            return getUser(id);
        }

        public void Create(CreateRequest model)
        {
            // validate
            if (_context.vueUsers.Any(x => x.Email == model.Email))
                throw new AppException("User with the email '" + model.Email + "' already exists");

            // map model to new user object
            var user = _mapper.Map<vueUser>(model);

            // save user
            _context.vueUsers.Add(user);
            _context.SaveChanges();
        }

        public void Update(int id, UpdateRequest model)
        {
            var user = getUser(id);

            // validate
            if (model.Email != user.Email && _context.vueUsers.Any(x => x.Email == model.Email))
                throw new AppException("User with the email '" + model.Email + "' already exists");

            // copy model to user and save
            _mapper.Map(model, user);
            _context.vueUsers.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = getUser(id);
            _context.vueUsers.Remove(user);
            _context.SaveChanges();
        }

        // helper methods

        private vueUser getUser(int id)
        {
            var user = _context.vueUsers.Find(id);
            if (user == null) 
            {
                user = new vueUser();
            }
            return user;
        }
    }
}
