using MealsApp.Classes;
using MealsApp.UI;
using System.Windows.Forms;

namespace MealsApp
{
    internal class CategoriesSearch
    {
		public static void Search(Panel ElementsPanel, string Text)
		{

			ElementsPanel.Controls.Clear();

			if (string.IsNullOrEmpty(Text))
			{
				UIRender.FillPanel(ElementsPanel, AppUI.ctrlsStore.CategoriesCtrls);

				return;
			}
			else
			{
				Text = Text.ToLower();

				foreach (ElementCtrl ctrl in AppUI.ctrlsStore.CategoriesCtrls)
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
