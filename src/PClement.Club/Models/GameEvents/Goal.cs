using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models.GameEvents
{
    public class Goal
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }
        public Guid GameId { get; set; }
        public Game Game { get; set; }
        public Guid PlayerId { get; set; }
        public Member Player { get; set; }
        public TimeSpan  Time { get; set; }
        public bool IsOwnGoal { get; set; }
        public GameHalf Half { get; set; }
        public BodyPart BodyPart { get; set; }

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
