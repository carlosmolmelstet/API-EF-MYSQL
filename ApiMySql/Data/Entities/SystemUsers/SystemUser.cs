using ApiMySql.Data.Entities.Positions;
using System;

namespace ApiMySql.Data.Entities.SystemUsers
{
    public class SystemUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Guid PositionId { get; set; }
        public virtual Position Position { get; set; }
    }
}
