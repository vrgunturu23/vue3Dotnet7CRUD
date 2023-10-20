using System.ComponentModel.DataAnnotations;

namespace vueCRUDSampleAPI.Models.Users
{
    public class CreateRequest
    {        
        public required string FirstName { get; set; }

        public required string LastName { get; set; }
        
        [EmailAddress]
        public required string Email { get; set; }

    }
}
