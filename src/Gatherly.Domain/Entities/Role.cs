using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gatherly.Domain.Entities;
public sealed class Role 
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public ICollection<Permission> Permissions { get; set; }
    public ICollection<Member> Members { get; set; }
}
