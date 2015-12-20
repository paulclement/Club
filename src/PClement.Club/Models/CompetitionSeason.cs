using System;
using System.Collections.Generic;
using PClement.Club.Models.Competition;

namespace PClement.Club.Models
{
    public class CompetitionSeason
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        public Guid CompetitionId { get; set; }
        public Competition.Competition Competition { get; set; }
        public int Year { get; set; }
        public Guid DivisionId { get; set; }
        public Division Division { get; set; }
        
        public List<Team> Teams { get; set; }
        public List<Game> Games { get; set; }

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
