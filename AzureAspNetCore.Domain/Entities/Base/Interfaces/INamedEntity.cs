using System;
using System.Collections.Generic;
using System.Text;

namespace AzureAspNetCore.Domain.Entities.Base.Interfaces
{
    interface INamedEntity : IBaseEntity
    {
         string Name { get; set; }
    }
}
