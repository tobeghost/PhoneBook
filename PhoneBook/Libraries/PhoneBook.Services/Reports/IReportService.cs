using PhoneBook.Domain.Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Services.Reports
{
    /// <summary>
    /// Report service interface
    /// </summary>
    public interface IReportService
    {
        /// <summary>
        /// Create new report
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        Task InsertReport(Report report);

        /// <summary>
        /// Delete report
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        Task DeleteReport(Report report);

        /// <summary>
        /// Delete report by id
        /// </summary>
        /// <param name="reportId"></param>
        /// <returns></returns>
        Task DeleteReportById(string reportId);

        /// <summary>
        /// Update report
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        Task UpdateReport(Report report);

        /// <summary>
        /// Get report by id
        /// </summary>
        /// <param name="reportId"></param>
        /// <returns></returns>
        Task<Report> GetReportById(string reportId);

        /// <summary>
        /// Gets all reports
        /// </summary>
        /// <returns></returns>
        Task<List<Report>> GetAllReports();
    }
}
