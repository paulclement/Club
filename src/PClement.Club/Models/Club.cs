﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models
{
    public class Club
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the club
        /// </summary>
        public String Name { get; set; }

        /// <summary>
        /// Club's creation date
        /// </summary>
        public DateTime CreationDate { get; set; }


        public string Address { get; set; }
        public Uri MapUri { get; set; }

        public byte[] Flag { get; set; }

        public Guid StadiumId { get; set; }
        public Stadium Stadium { get; set; }

        public Guid PresidentId { get; set; }
        public Member President { get; set; }
        public List<Member> Staff { get; set; }

        /// <summary>
        /// Teams 
        /// </summary>
        public List<Team> Teams { get; set; }

        public List<Sponsor> Sponsors { get; set; }

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
