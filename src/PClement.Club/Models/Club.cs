using System;
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


        //TODO: add properties
        // address
        // google map link 
        // stadium + stadium address + googlemap link


        /// <summary>
        /// Indicates if this club is active in database
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
        /// Teams for this category
        /// </summary>
        public List<AgeCategory> teams { get; set; }
    }
}
