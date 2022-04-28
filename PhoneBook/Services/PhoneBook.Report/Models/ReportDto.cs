using PhoneBook.Domain.Reports;

namespace PhoneBook.Report.Models
{
    public class ReportDto
    {
        public string Id { get; set; }
        public ReportType ReportType { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOnDate { get; set; } = DateTime.Now;
        public ReportStatusType Status { get; set; } = ReportStatusType.Requested;
    }
}
