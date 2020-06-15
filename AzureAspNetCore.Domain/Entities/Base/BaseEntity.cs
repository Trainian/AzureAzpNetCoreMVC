using System;
using System.Collections.Generic;
using System.Text;
using AzureAspNetCore.Domain.Entities.Base.Interfaces;

namespace AzureAspNetCore.Domain.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
    }
}
