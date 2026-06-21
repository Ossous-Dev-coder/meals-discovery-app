using MealAppBusiness;
using MealsApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealAppBusiness.Classes;

namespace MealsApp.Classes
{
    internal class MealAdapter : IElement
    {
        readonly private Meal _meal;

        public string Name  => _meal.strMeal;

        public string ThumbUrl => _meal.strMealThumb;

		public MealAdapter(Meal meal)
        {
            _meal = meal;
        }
    }
}
