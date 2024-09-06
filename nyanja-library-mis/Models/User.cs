using nyanja_library_mis.Types;

namespace nyanja_library_mis.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MembershipDate { get; set; }
        public MembershipType MembershipType { get; set; }

    }
}
