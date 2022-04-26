using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Reports
{
    /// <summary>
    /// Represents a report
    /// </summary>
    public partial class Report : BaseEntity
    {
        /// <summary>
        /// Gets or sets the user id
        /// </summary>
        public string CreatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the request date
        /// </summary>
        public DateTime CreatedOnDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Gets or sets report status
        /// </summary>
        public ReportStatusType Status { get; set; } = ReportStatusType.Requested;
    }
}
