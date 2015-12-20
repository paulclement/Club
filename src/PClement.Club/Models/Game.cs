using PClement.Club.Models.Competition;
using PClement.Club.Models.GameEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models
{
    public class Game
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        public Guid CompetitionSeasonId { get; set; }
        public CompetitionSeason CompetitionSeason { get; set; }
        public DateTime Date { get; set; }
        public int SpectatorsCount { get; set; }
        public bool HasBeenPostponed { get; set; }
        public PostponingReason PostponingReason { get; set; }
        public string CustomPostponingReason { get; set; }


        /// <summary>
        /// Step in the competition depending on the competition format, ie: 17th game, or semi-finals, ...
        /// </summary>
        public string Step { get; set; }

        //TODO: add properties : temperature, weather
        public Guid StadiumFieldId { get; set; }
        public StadiumField StadiumField { get; set; }
        
        public Guid ReceivingClubId { get; set; }
        public Club ReceivingClub { get; set; }
        public Guid ReceivingTeamId { get; set; }
        public Team ReceivingTeam { get; set; }
        public Guid VisigingClubId { get; set; }
        public Club VisigingClub { get; set; }
        public Guid VisitingTeamId { get; set; }
        public Team VisitingTeam { get; set; }

        public List<Card> YellowCards { get; set; }
        public List<Card> RedCard { get; set; }
        public List<Goal> Goals { get; set; }
        
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
