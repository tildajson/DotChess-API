using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotChess_API.Models;

namespace DotChess_API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(User user);
    }
}