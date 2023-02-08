using System;
using System.Collections.Generic;

#nullable disable

namespace OpenshiftDotNetSqlServerMvc.DataAccess.Entities.ApplicationDb
{
    public partial class State
    {
        public int StateId { get; set; }
        public string StateName { get; set; }
        public string Abbreviation { get; set; }
        public string StateCode { get; set; }
        public int CountryId { get; set; }
        public int CountrySubdivisionTypeId { get; set; }
        public bool IsActive { get; set; }

        public virtual Country Country { get; set; }
        public virtual CountrySubdivisionType CountrySubdivisionType { get; set; }
    }
}
