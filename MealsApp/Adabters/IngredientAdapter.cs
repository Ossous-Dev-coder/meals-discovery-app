using MealsApp.Interfaces;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MealsApp.Classes;
using MealAppBusiness.Classes;
using System.Drawing;

namespace MealsApp.Classes
{

    class IngredientAdapter : IElement
    {
        private readonly Ingredient _ingredient;

        public string Name => $"{_ingredient.Measure} {_ingredient.Name}";

        public string Measure => _ingredient.Measure;

        public string ThumbUrl => _ingredient.ThumbUrl;


		public IngredientAdapter(Ingredient ingredient)
        {
            _ingredient = ingredient;
        }
    }
}
