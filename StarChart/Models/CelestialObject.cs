using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? OrbitedObjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public TimeSpan OrbitalPeriod { get; set; }
    }
}
