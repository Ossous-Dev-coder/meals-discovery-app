
using MealAppBusiness.Classes;
using MealsApp.Classes;
using MealsApp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

 
namespace MealsApp
{
    internal static class  CtrlsBuilder
    {

		public static void BuildCategoriesCrls(List<Category> categories, Action<ElementCtrl> onClickMethod)
		{

			if (categories != null)
			{

				AppUI.ctrlsStore.CategoriesCtrls.Clear();

				foreach (Category category in categories)
				{
					ElementCtrl CategoryCtrl = new ElementCtrl(new CategoryAdapter(category), onClickMethod);


					AppUI.ctrlsStore.CategoriesCtrls.Add(CategoryCtrl);

				}
			}

			else
				App.ErrorsLoggingService.Log("Categories list was null!");

		}

		public static void BuildMealsCrls(List<Meal> Meals, Action<ElementCtrl> OnClickMethod)
		{

			if (Meals != null)
			{

				AppUI.ctrlsStore.MealsCtrls.Clear();

				foreach (Meal Meal in Meals)
				{
					ElementCtrl MealCtrl = new ElementCtrl(new MealAdapter(Meal), OnClickMethod);

					AppUI.ctrlsStore.MealsCtrls.Add(MealCtrl);
				}
			}

			else
				App.ErrorsLoggingService.Log("Meals list was null!");

		}

		public static void BuildingredientsCrls(List<Ingredient> ingredients, Action<ElementCtrl> OnClickMethod)
		{

			if (ingredients != null)
			{

				AppUI.ctrlsStore.IngredientsCtrls.Clear();

				foreach (Ingredient ingredient in ingredients)
				{
					ElementCtrl MealCtrl = new ElementCtrl(new IngredientAdapter(ingredient), OnClickMethod);

					AppUI.ctrlsStore.IngredientsCtrls.Add(MealCtrl);
				}
			}

			else
				App.ErrorsLoggingService.Log("Ingredient list was null!");


		}


		public static async Task SetCtrlsImages(List<ElementCtrl> ctrls, CancellationToken ct)
		{
			using (var sem = new SemaphoreSlim(20))
			{

				var tasks = ctrls.Select(async ctrl =>
				{

					try
					{
						await sem.WaitAsync(ct);

						ctrl.Thumb = await ImageService.LoadThumbs(ctrl.Element.ThumbUrl, ct);

						ctrl.Invoke((Action)(() => ctrl.SetImage()));
					}
					catch (OperationCanceledException)
					{

					}
					catch (Exception ex)
					{
						App.ErrorsLoggingService.Log(ex.ToString());
					}
					finally
					{
						sem.Release();
					}

				}).ToList();

				await Task.WhenAll(tasks);

			}
		}

		public static async Task SetIngredientsCtrlsImages(List<ElementCtrl> ctrls, CancellationToken ct)
		{
			using (var sem = new SemaphoreSlim(20))
			{

				var tasks = ctrls.Select(async ctrl =>
				{

					try
					{
						await sem.WaitAsync(ct);

						ctrl.Thumb = await ImageService.LoadIngredientsThumbs(ctrl.Element.ThumbUrl, ct);

						ctrl.Invoke((Action)(() => ctrl.SetImage()));
					}
					catch (OperationCanceledException)
					{

					}
					catch (Exception ex)
					{
						App.ErrorsLoggingService.Log(ex.ToString());
					}
					finally
					{
						sem.Release();
					}

				}).ToList();

				await Task.WhenAll(tasks);

			}
		}



	}

}
