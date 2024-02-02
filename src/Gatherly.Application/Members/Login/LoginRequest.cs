using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gatherly.Application.Members.Login;
public record LoginRequest
{
    public string Email { get; set; }
}
