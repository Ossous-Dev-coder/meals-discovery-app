using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MealsApp.Classes;
using MealsApp.UI;
using MealsApp.UI_Elements;


namespace MealsApp
{
    public partial class Form1: Form 
    {
		public enum Position { Categories, Meals, MealDetails}

		public Position _currentPosition;   

		ElementCtrl _chosenCtrl;

		MealDetails mealDetails;

		NoInternetCrtl _noInternetCrtl;

		CancellationTokenSource _mealsThumbsCts;

		CancellationTokenSource _ingredientsThumbsCts;

		


		public Form1() 
        {
            InitializeComponent();

			_currentPosition = Position.Categories;

			_mealsThumbsCts = new CancellationTokenSource();

			_ingredientsThumbsCts = new CancellationTokenSource();

			_noInternetCrtl = new NoInternetCrtl(_onRetry);

		}

		void NoInternet()
		{
			Controls.Clear();

			Controls.Add(_noInternetCrtl);
		}



		void _setHeaderImage(Image thumb)
		{
			pbTitle.Image = thumb;
		}

		
		void _drawAllMeals()
		{
			_currentPosition = Position.Meals;

			filter.Clear();

			filter.OnSearch(_searchInMeals);

			ElementsPanel.Controls.Clear();

			if (AppUI.ctrlsStore.MealsCtrls != null)
			{
				foreach (ElementCtrl ctrl in AppUI.ctrlsStore.MealsCtrls)
				{
					ElementsPanel.Controls.Add(ctrl);
				}
			}

		}

	
        public void _searchInCategories(string Text)
		{
			CategoriesSearch.Search(ElementsPanel, Text);
		}

		
		void _searchInMeals(string Text)
		{ 
			 MealsSearch.Search(ElementsPanel,Text);
		}

		
		async void Form1_LoadAsync(object sender, EventArgs e)
		{
			if (!await InternetService.CheckForConnection())
			{
				NoInternet();

				return;
			}

			await Controller.FetchCategories();

			await Task.Run(() => CtrlsBuilder.BuildCategoriesCrls(App.dataStore.categories, _showCategoryMeals));

			UIRender.DrawAllCategories(this, filter, ElementsPanel, _searchInCategories);

			await CtrlsBuilder.SetCtrlsImages(AppUI.ctrlsStore.CategoriesCtrls, _mealsThumbsCts.Token);
		}

		void _onRetry()
		{
			if(ElementsPanel.Controls.Count == 0)

				Form1_LoadAsync(null, null);

			Controls.Remove(_noInternetCrtl);

			Controls.Add(ElementsPanel);

			Controls.Add(btnBack);

			Controls.Add(pbTitle);

			Controls.Add(lblTitle);

			Controls.Add(filter);
			
		}



		async void _showCategoryMeals(ElementCtrl categoryCtrl) 
		{
			if (!await InternetService.CheckForConnection())
			{
				NoInternet();

				return;
			}

			_chosenCtrl = categoryCtrl;

			categoryCtrl.OnThumbChange = _setHeaderImage;

			_updateHeader();

			await Controller.FetchMeals(categoryCtrl.Element.Name);

			await Task.Run(() => CtrlsBuilder.BuildMealsCrls(App.dataStore.meals, _showMealDetails));

			_drawAllMeals();

			await CtrlsBuilder.SetCtrlsImages(AppUI.ctrlsStore.MealsCtrls,_mealsThumbsCts.Token);

		}


		
		async void _showMealDetails(ElementCtrl mealCtrl) 
		{
			if (!await InternetService.CheckForConnection())
			{
				NoInternet();

				return;
			}

			_currentPosition = Position.MealDetails;

			mealDetails = new MealDetails(mealCtrl, _ingredientsThumbsCts.Token);

			Controls.Clear();

			Controls.Add(btnBack);

			Controls.Add(mealDetails);

			CancelButton = btnBack;

		}

		void lblTitle_SizeChanged(object sender, EventArgs e)
		{
			pbTitle.Location = new Point(lblTitle.Size.Width, pbTitle.Location.Y);
		}

		void btnBack_Click(object sender, EventArgs e)
		{
			if (_currentPosition == Position.Meals)
			{
				_mealsThumbsCts.Cancel();

				App.dataStore.meals.Clear();

				AppUI.ctrlsStore.MealsCtrls.Clear();

				btnBack.Visible = false;

				pbTitle.Image = Properties.Resources.main_dish;

				lblTitle.Text = "Categories";

				UIRender.DrawAllCategories(this, filter, ElementsPanel, _searchInCategories);

				_mealsThumbsCts = new CancellationTokenSource();
			}
			else if (_currentPosition == Position.MealDetails)
			{
				_ingredientsThumbsCts.Cancel();

				AppUI.ctrlsStore.IngredientsCtrls.Clear();

				this.Controls.Clear();

				UIRender.drawHeader(this, lblTitle, pbTitle, ElementsPanel, filter, btnBack, _chosenCtrl);

				CancelButton = btnBack;

				_drawAllMeals();

				_ingredientsThumbsCts = new CancellationTokenSource();
			}

		}

		void  _updateHeader()
		{
			btnBack.Visible = true;

			CancelButton = btnBack;

			lblTitle.Text = _chosenCtrl.Element.Name;

			pbTitle.Image = _chosenCtrl.Thumb;
		}

	
	}


}
