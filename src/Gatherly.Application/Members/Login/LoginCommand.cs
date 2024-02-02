using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gatherly.Application.Abstractions.Messaging;

namespace Gatherly.Application.Members.Login;
public record LoginCommand(string Email) : ICommand<string>;

