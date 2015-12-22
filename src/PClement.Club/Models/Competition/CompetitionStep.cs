using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models.Competition
{
    public class CompetitionStep
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        public int Index { get; set; }
        public string Name { get; set; }

        public Guid CompetitionId { get; set; }
        public Competition Competition { get; set; }

        public CompetitionStepFormat Format { get; set; }
        
        #region Cup format

        public int Depth { get; set; }

        #endregion
        
        #region League format

        public int NumberOfTeams { get; set; }
        public int NumberOfGroups { get; set; }
        public int ReceivingGamesCount { get; set; }
        public int VisitingGamesCount { get; set; }
        public LeagueRankingAlgorithm LeagueRankingAlgorithm { get; set; }

        #endregion

        public List<CompetitionEvent> Events { get; set; }


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
