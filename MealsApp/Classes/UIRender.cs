using MealsApp.UI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MealsApp.Classes
{
	internal static class UIRender
	{
		static public void FillPanel(Panel panel, List<ElementCtrl> ctrls)
		{
			if (ctrls.Count != 0)
			{
				panel.Controls.Clear();

				foreach (ElementCtrl ctrl in ctrls)

					panel.Controls.Add(ctrl);
			}
		}

		public static void drawHeader(Form1 form, Label lbl, PictureBox pb, FlowLayoutPanel panel, Filter filter, Button btnBack, ElementCtrl ctrl)
		{
			lbl.Text = ctrl.Element.Name;
			pb.Image = ctrl.Thumb;
			form.Controls.Add(btnBack);
			form.Controls.Add(lbl);
			form.Controls.Add(pb);
			form.Controls.Add(filter);
			form.Controls.Add(panel);
			
		}
		public static void DrawAllCategories(Form1 form, Filter filter, FlowLayoutPanel ElementsPanel, Action<string> onSearch)
		{
			form._currentPosition = Form1.Position.Categories;

			filter.Clear();

			filter.OnSearch(onSearch); 

			ElementsPanel.Controls.Clear();

			if (AppUI.ctrlsStore.CategoriesCtrls != null)
			{
				foreach (ElementCtrl ctrl in AppUI.ctrlsStore.CategoriesCtrls)
				{
					ElementsPanel.Controls.Add(ctrl);
				}
			}
		}
	}
}
