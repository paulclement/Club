using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models
{
    public class Member
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NickName { get; set; }
        public DateTime BirthDate { get; set; }
        public string LicenceNumber { get; set; }
        
        public bool IsPlayer { get; set; }

        #region Staff member properties

        public StaffRole StaffRole { get; set; }
        public Team MainCoachedTeam { get; set; }

        #endregion

        #region Player properties

        public DominantSide DominantSide { get; set; }
        public PlayerPosition Position { get; set; } 

        #endregion



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
