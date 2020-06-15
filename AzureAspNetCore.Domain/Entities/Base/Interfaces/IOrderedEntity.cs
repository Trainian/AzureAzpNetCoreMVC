using System;
using System.Collections.Generic;
using System.Text;

namespace AzureAspNetCore.Domain.Entities.Base.Interfaces
{
    interface IOrderedEntity : INamedEntity
    {
        int Order { get; set; }
    }
}
