using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiMySql.Models
{
    public class ResponseData<T>
    {
        public int Total { get; set; }
        public IEnumerable<T> Data { get; set; }
    }
}
