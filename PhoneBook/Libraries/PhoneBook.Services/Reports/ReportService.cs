using PhoneBook.Domain.Data;
using PhoneBook.Domain.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services.Reports
{
    /// <summary>
    /// Report Service
    /// </summary>
    public partial class ReportService : IReportService
    {
        private readonly IRepository<Report> _reportRepository;

        public ReportService(IRepository<Report> reportRepository)
        {
            _reportRepository = reportRepository;
        }
    }
}
