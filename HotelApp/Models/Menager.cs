//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Menager
    {
        public int MenagerId { get; set; }
        public int UserId { get; set; }
        public int HotelFloor { get; set; }
        public int Experience { get; set; }
        public int QualificationLevelId { get; set; }
    
        public virtual QualificationLevel QualificationLevel { get; set; }
        public virtual UserHotel UserHotel { get; set; }
    }
}
