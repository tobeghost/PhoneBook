using MongoDB.Driver;
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
    public class ReportService : IReportService
    {
        private readonly IRepository<Report> _reportRepository;

        public ReportService(IRepository<Report> reportRepository)
        {
            _reportRepository = reportRepository;
        }

        /// <summary>
        /// Create new report
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task InsertReport(Report report)
        {
            if (report == null)
                throw new ArgumentNullException("report");

            await _reportRepository.InsertAsync(report);
        }

        /// <summary>
        /// Delete report
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteReport(Report report)
        {
            if (report == null)
                throw new ArgumentNullException("report");

            await _reportRepository.DeleteAsync(report);
        }

        /// <summary>
        /// Delete report by id
        /// </summary>
        /// <param name="reportId"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task DeleteReportById(string reportId)
        {
            if (string.IsNullOrEmpty(reportId))
                throw new ArgumentNullException("reportId");

            await _reportRepository.DeleteAsync(reportId);
        }

        /// <summary>
        /// Update report
        /// </summary>
        /// <param name="report"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task UpdateReport(Report report)
        {
            if (report == null)
                throw new ArgumentNullException("report");

            await _reportRepository.UpdateAsync(report);
        }

        /// <summary>
        /// Get report by id
        /// </summary>
        /// <param name="reportId"></param>
        /// <returns>User</returns>
        /// <exception cref="ArgumentNullException"></exception>
        public virtual async Task<Report> GetReportById(string reportId)
        {
            if (string.IsNullOrEmpty(reportId))
                throw new ArgumentNullException("reportId");

            return await _reportRepository.GetByIdAsync(reportId);
        }

        /// <summary>
        /// Gets all reports
        /// </summary>
        /// <returns></returns>
        public virtual async Task<List<Report>> GetAllReports()
        {
            return await _reportRepository.Collection.Find(i => true).SortByDescending(x => x.CreatedOnDate).ToListAsync();
        }
    }
}
