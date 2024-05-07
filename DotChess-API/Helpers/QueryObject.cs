using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotChess_API.Helpers
{
    public class QueryObject
    {
        public string? ClubName { get; set; } = null;
        public string? Location { get; set; } = null;
        public string? SortBy { get; set; } = null;
        public bool IsDescending { get; set; } = false;
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 20;
    }
}