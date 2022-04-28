using AutoMapper;
using PhoneBook.Report.Models;

namespace PhoneBook.Report.Mappers
{
    public class ReportMappingProfile : Profile
    {
        public ReportMappingProfile()
        {
            CreateMap<PhoneBook.Domain.Reports.Report, ReportDto>()
                .ForMember(x => x.ReportType, x => x.MapFrom(c => c.Type));

            CreateMap<ReportDto, PhoneBook.Domain.Reports.Report>()
                .ForMember(x => x.Type, x => x.MapFrom(c => c.ReportType));
        }
    }
}
