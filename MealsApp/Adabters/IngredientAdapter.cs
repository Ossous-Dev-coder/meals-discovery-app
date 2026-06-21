using MealsApp.Interfaces;
using MealAppBusiness.Classes;

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
