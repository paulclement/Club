using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models
{
    public class Sponsor
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public Uri Website { get; set; }
        public byte[] Logo { get; set; }

        public List<Club> Clubs { get; set; }

        #region Common properties

        /// <summary>
        /// Indicates if this record is active in database
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

        /// <summary>
        /// User of last update in database
        /// </summary>
        public string LastUpdateUser { get; set; }

        /// <summary>
        /// Time of last update in database
        /// </summary>
        public DateTime LastUpdateTime { get; set; }

        #endregion
    }
}
