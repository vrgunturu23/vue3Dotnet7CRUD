using System.ComponentModel.DataAnnotations;

namespace vueCRUDSampleAPI.Models.Users
{
    public class UpdateRequest
    {
        public required string FirstName { get; set; }
        public string? LastName { get; set; }

        [EmailAddress]
        public required string Email { get; set; }


        private static string? ReplaceEmptyWithNull(string value)
        {
            return string.IsNullOrEmpty(value) ? null : value;
        }
    }
}
