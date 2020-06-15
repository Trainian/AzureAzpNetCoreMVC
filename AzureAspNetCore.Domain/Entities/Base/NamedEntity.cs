using System;
using System.Collections.Generic;
using System.Text;
using AzureAspNetCore.Domain.Entities.Base.Interfaces;

namespace AzureAspNetCore.Domain.Entities.Base
{
    public class NamedEntity : BaseEntity, INamedEntity
    {
        public string Name { get; set; }
    }
}
