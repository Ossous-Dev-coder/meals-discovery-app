using MealsApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using MealAppBusiness.Classes;

namespace MealsApp.Classes
{
    internal class CategoryAdapter : IElement
    {
        readonly private Category _category;

        public string Name => _category.strCategory;

        public string ThumbUrl => _category.strCategoryThumb;


        public CategoryAdapter(Category category)
        {
            _category = category;
        }

    }
}
