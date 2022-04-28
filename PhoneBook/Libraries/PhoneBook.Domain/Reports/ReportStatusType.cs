using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook.Domain.Reports
{
    public enum ReportStatusType
    {
        /// <summary>
        /// Requested
        /// </summary>
        Requested = 0,

        /// <summary>
        /// Preparing
        /// </summary>
        Preparing = 1,

        /// <summary>
        /// Completed
        /// </summary>
        Completed = 2
    }
}
