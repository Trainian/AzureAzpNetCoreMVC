using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureAspNetCore.Infrastructure.Interfaces;
using AzureAspNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace AzureAspNetCore.ViewComponents
{
    public class SectionViewComponent : ViewComponent
    {
        private readonly IProductData _productData;

        public SectionViewComponent(IProductData productData)
        {
            _productData = productData;
        }

        public IViewComponentResult Invoke()
        {
            var sections = GetSections();
            return View(sections);
        }

        private List<SectionView> GetSections()
        {
            var categories = _productData.GetSections();
            var parentCategories = categories.Where(p => !p.ParentId.HasValue).ToArray();
            var parentSections = new List<SectionView>();
            foreach (var parentCategory in parentCategories)
            {
                parentSections.Add(new SectionView()
                {
                    Id = parentCategory.Id,
                    Name = parentCategory.Name,
                    Order = parentCategory.Order,
                    ParrentSection = null
                });
            }

            foreach (var parentSection in parentSections)
            {
                var chieldCategories = categories.Where(e => e.ParentId.Equals(parentSection.Id));
                foreach (var chieldCategory in chieldCategories)
                {
                    parentSection.ChildSection.Add(new SectionView()
                    {
                        Id = chieldCategory.Id,
                        Name = chieldCategory.Name,
                        Order = chieldCategory.Order,
                        ParrentSection = parentSection
                    });
                }

                parentSection.ChildSection = parentSection.ChildSection.OrderBy(c => c.Order).ToList();
            }

            parentSections = parentSections.OrderBy(c => c.Order).ToList();

            return parentSections;
        }
    }
}
