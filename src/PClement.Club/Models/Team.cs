using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models
{
    public class Team
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Club of the team
        /// </summary>
        public Club Club { get; set; }

        /// <summary>
        /// Age category of the team (veterans, seniors, U19, ...)
        /// </summary>
        public AgeCategory Category { get; set; }

        /// <summary>
        /// Indicates if this team is active in database
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// User of creation in database
        /// </summary>
        public string CreationUser { get; set; }

        /// <summary>
        /// Time of creation in database
        /// </summary>
        public DateTime CreationTime { get; set; }
    }
}
