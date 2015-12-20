using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PClement.Club.Models
{
    /// <summary>
    /// This class represents an age category. IE: veterans, seniors, U19, ...
    /// </summary>
    public class AgeCategory
    {
        /// <summary>
        /// Technical GUID
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Name of the category, ie veterans, senior, U19, ...
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gender of the category
        /// </summary>
        public Gender Gender { get; set; }
        
        /// <summary>
        /// Teams for this age category
        /// </summary>
        public List<AgeCategory> teams { get; set; }

        /// <summary>
        /// Indicates if this age category is active in database
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
