﻿using EmployeeManagement.Api.Response;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Api.Command.Client
{
    public class AddClientCommand : IRequest<BaseResponse>
    {
        public string ClientName { get; set; }
        public string ClientLocation { get; set; }
    }
}
