using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gatherly.Domain.Entities;

namespace Gatherly.Application.Abstractions;
public interface IJWTProvider
{
    string Generate(Member member);
}
