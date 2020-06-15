using System;
using System.Collections.Generic;
using System.Text;
using AzureAspNetCore.Domain.Entities.Base;

namespace AzureAspNetCore.Domain.Entities
{
    public class Section : OrderedEntity
    {
        /// <summary>
        /// Родительская секция (при наличии)
        /// </summary>
        public int? ParentId { get; set; }
    }
}
