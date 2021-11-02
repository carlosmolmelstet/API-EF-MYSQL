using ApiMySql.Data.Entities.SystemUsers;
using System;
using System.Collections.Generic;

namespace ApiMySql.Data.Entities.Positions
{
    public class Position
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public virtual  IEnumerable<SystemUser> SystemUsers { get; set; }
    }
}
