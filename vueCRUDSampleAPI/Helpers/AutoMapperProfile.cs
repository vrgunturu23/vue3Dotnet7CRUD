using AutoMapper;
using vueCRUDSampleAPI.Entities;
using vueCRUDSampleAPI.Models.Users;

namespace vueCRUDSampleAPI.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            // CreateRequest -> User
            CreateMap<CreateRequest, vueUser>();

            // UpdateRequest -> User
            CreateMap<UpdateRequest, vueUser>()
                .ForAllMembers(x => x.Condition(
                    (src, dest, prop) =>
                    {
                        // ignore both null & empty string properties
                        if (prop == null) return false;
                        if (prop.GetType() == typeof(string) && string.IsNullOrEmpty((string)prop)) return false;

                        return true;
                    }
                ));
        }
    }
}
