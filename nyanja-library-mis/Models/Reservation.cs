using nyanja_library_mis.Types;

namespace nyanja_library_mis.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public DateTime ReservationDate { get; set; }
        public ReservationStatus Status { get; set; }
    }
}
