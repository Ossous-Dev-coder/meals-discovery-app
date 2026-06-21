using MealsApp.UI;
using System.Collections.Generic;


namespace MealsApp
{
    internal  class CtrlsStore
    {
        public List<ElementCtrl> CategoriesCtrls { get; set; }

        public List<ElementCtrl> MealsCtrls { get; set; }

        public List<ElementCtrl> IngredientsCtrls { get; set; }
        
        public CtrlsStore()
        {
            CategoriesCtrls = new List<ElementCtrl>();

            MealsCtrls = new List<ElementCtrl>();

            IngredientsCtrls = new List<ElementCtrl>();
        }

	}
}
