using System;
using System.Collections.Generic;
using System.Text;
using AzureAspNetCore.Domain.Entities.Base.Interfaces;

namespace AzureAspNetCore.Domain.Entities.Base
{
    public class OrderedEntity : NamedEntity, IOrderedEntity
    {
        public int Order { get; set; }
    }
}
