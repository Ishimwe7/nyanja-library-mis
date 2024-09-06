using Microsoft.EntityFrameworkCore;
using nyanja_library_mis.Types;

namespace nyanja_library_mis.Models
{
    public class Fine
    {
        public int Id { get; set; }
        public int LoanId { get; set; }

        [Precision(16,2)]
        public double amount { get; set; }
        public DateTime DateIssued { get; set; }
        public FineStatus Status { get; set; }
    }
}
