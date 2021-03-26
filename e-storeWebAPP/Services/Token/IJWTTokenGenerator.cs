using DataDomain.DataTables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace e_storeWebAPP.Services.Token
{
    public interface IJWTTokenGenerator
    {
        string GenerateToken(User user, IList<string> roles, IList<Claim> claims);
    }
}
