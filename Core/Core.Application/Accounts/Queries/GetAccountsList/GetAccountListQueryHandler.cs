﻿using FluentValidation.Results;
using Core.Application.Accounts.Models;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Common.Configuration;
using Core.Common.Exceptions;
using Core.Common.BaseClasses;
using Core.Domain.Entities;
using Core.Application.Accounts.Queries;
using System.Collections.Generic;
using Core.Common.Persistence.DocumentDatabase;

namespace Core.Application.Accounts.Queries
{
    public class GetAccountListQueryHandler : IRequestHandler<GetAccountsListQuery, List<AccountViewModel>>
    {
        //MediatR will automatically inject out dependencies
        private readonly IMediator _mediator;
        private readonly ICoreConfiguration _coreConfiguration;
        private readonly IDocumentContext _documentClient;


        public GetAccountListQueryHandler(IDocumentContext documentClient, ICoreConfiguration coreConfiguration, IMediator mediator)
        {
            _mediator = mediator;
            _coreConfiguration = coreConfiguration;
            _documentClient = documentClient;

        }

    public async Task<List<AccountViewModel>> Handle(GetAccountsListQuery request, CancellationToken cancellationToken)
        {
            // Prepare our domain model to be returned
            var accountsList = new List<AccountViewModel>();

            return accountsList;

        }
    }
}
