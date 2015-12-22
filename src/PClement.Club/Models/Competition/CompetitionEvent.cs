using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models.Competition
{
    /// <summary>
    /// This class represent a competition step event.
    /// If the competition step format is league, the event will be a match day.
    /// If the competition step format is cup, the event will be a match day.
    /// </summary>
    public class CompetitionEvent
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        public Guid ParentCompetitionStepId { get; set; }
        public CompetitionStep ParentCompetitionStep { get; set; }

        public int Index { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// Si on genre 32eme de finale Allez (= 1) ou retour (2)
        /// </summary>
        public int SameEventIndex { get; set; }




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
