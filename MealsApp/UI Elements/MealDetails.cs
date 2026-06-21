using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MealAppBusiness;
using MealsApp.Classes;
using MealsApp.UI;

namespace MealsApp.UI_Elements
{
    public partial class MealDetails: UserControl
    {

        DetailedMeal _meal;

        ElementCtrl _mealCtrl;

        MealsContainer<DetailedMeal> _mealsContainer;

        CancellationToken _ct;



        public MealDetails(ElementCtrl mealCtrl, CancellationToken ct)
        {
            InitializeComponent();


            Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Location = new Point(1, -1);

            Dock = DockStyle.Fill;

            _mealCtrl = mealCtrl;

            mealCtrl.OnThumbChange = _setImage;

            _ct = ct;
		}

		void _setImage(Image thumb)
		{
            pbMealThump.Image = thumb;
		}


		private async void MealDetails_Load(object sender, EventArgs e)
        {
            if (!DesignMode)

                await _getMeal();

        }

        async Task _getMeal()
        {

			_mealsContainer = await Controller.FetchMeal(_mealCtrl.Element.Name);

			if (_mealsContainer?.meals.Count == 0 || _mealsContainer == null)
			{
				App.ErrorsLoggingService.Log("Meals list was empty.");

				return;
			}

			_meal = _mealsContainer?.meals[0];

			lblName.Text = _mealCtrl.Element.Name;

            pbMealThump.Image = _mealCtrl.Thumb;

			lblInstructions.Text = _meal.strInstructions;

			_meal.GetIngridents(_mealsContainer.JsonObj);

			await _setIngredients();

		}

        private async Task _setIngredients()
        {

			if (_meal.Ingredients != null)
            {

                await Task.Run(() => CtrlsBuilder.BuildingredientsCrls(_meal.Ingredients, null));

                UIRender.FillPanel(flpIngredients, AppUI.ctrlsStore.IngredientsCtrls);

                await CtrlsBuilder.SetIngredientsCtrlsImages(AppUI.ctrlsStore.IngredientsCtrls, _ct); 
            }   
            else
                App.ErrorsLoggingService.Log("Ingredients list was null!");

        }

	}
}
