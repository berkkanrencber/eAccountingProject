﻿using eAccountingServer.Domain.Abstractions;
using eAccountingServer.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eAccountingServer.Domain.Entities;

public sealed class Company : Entity
{
    public string Name { get; set; } = string.Empty;
    public string FullAddress { get; set; } = string.Empty;
    public string TaxDepartment { get; set; } = string.Empty;
    public string TaxNumber { get; set; } = string.Empty;
    public Database Database { get; set; } = new(string.Empty, string.Empty, string.Empty, string.Empty);
}