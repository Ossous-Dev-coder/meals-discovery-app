using MealsApp.Classes;
using MealsApp.UI;
using System.Windows.Forms;

namespace MealsApp
{
    internal class MealsSearch
    {
		public static void Search(Panel ElementsPanel, string Text)
		{

			ElementsPanel.Controls.Clear();

			if (string.IsNullOrEmpty(Text))
			{
				UIRender.FillPanel(ElementsPanel, AppUI.ctrlsStore.MealsCtrls);

				return;
			}
			else
			{
				Text = Text.ToLower();

				foreach (ElementCtrl ctrl in AppUI.ctrlsStore.MealsCtrls)
				{
					if (ctrl.Element.Name.ToLower().Contains(Text))
					{
						ElementsPanel.Controls.Add(ctrl);
					}
				}
			}
		}

	}



}
