using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Domain.Reports;
using PhoneBook.Framework.Controllers;
using PhoneBook.Report.Models;
using PhoneBook.Services.Reports;

namespace PhoneBook.Report.Controllers
{
    [Route("api/reports")]
    [ApiController]
    public class ReportsController : BaseController
    {
        private readonly IReportService _reportService;
        private readonly IMapper _mapper;

        public ReportsController(IReportService reportService, IMapper mapper)
        {
            _reportService = reportService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<List<ReportDto>> GetAll()
        {
            var data = await _reportService.GetAllReports();

            var response = _mapper.Map<List<ReportDto>>(data);

            return response;
        }

        [HttpGet("{id}")]
        public async Task<ReportDto> GetById(string id)
        {
            var data = await _reportService.GetReportById(id);

            var response = _mapper.Map<ReportDto>(data);

            return response;
        }

        [HttpPost]
        [Route("report-by-location")]
        public async Task<ReportDto> CreateReportByLocation()
        {
            var report = new Domain.Reports.Report();
            report.Type = ReportType.StatsByLocation;
            report.Description = $"Report of Location Stats";
            report.Status = ReportStatusType.Requested;
            report.CreatedOnDate = DateTime.Now;

            await _reportService.InsertReport(report);

            var response = _mapper.Map<ReportDto>(report);

            return response;
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _reportService.DeleteReportById(id);

            return Ok();
        }
    }
}
