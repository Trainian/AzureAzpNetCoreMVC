using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Domain.Entities.Base;

namespace AzureAspNetCore.Models
{
    public class SectionView : OrderedEntity
    {
        public List<SectionView> ChildSection { get; set; }

        public SectionView ParrentSection { get; set; }

        public SectionView()
        {
            ChildSection = new List<SectionView>();
        }
    }
}
