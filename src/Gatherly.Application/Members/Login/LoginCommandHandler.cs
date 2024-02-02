using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gatherly.Application.Abstractions;
using Gatherly.Application.Abstractions.Messaging;
using Gatherly.Domain.Entities;
using Gatherly.Domain.Errors;
using Gatherly.Domain.Repositories;
using Gatherly.Domain.Shared;
using Gatherly.Domain.ValueObjects;
using MediatR;

namespace Gatherly.Application.Members.Login;
internal sealed class LoginCommandHandler
    : ICommandHandler<LoginCommand, string>
{
    private readonly IMemberRepository _memberRepository;

    private readonly IJWTProvider _jWTProvider;

    public LoginCommandHandler(IMemberRepository memberRepository, IJWTProvider jWTProvider)
    {
        _memberRepository = memberRepository;
        _jWTProvider = jWTProvider;
    }

    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        Result<Email> email = Email.Create(request.Email);

        Member? member = await _memberRepository.GetByEmailAsync(email.Value, cancellationToken);

        if (member is null)
        {
            return Result.Failure<string>(
                DomainErrors.Member.InvalidCredentials);
        }


        string token = _jWTProvider.Generate(member);

        return token;


    }
}
