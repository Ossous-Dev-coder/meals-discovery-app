using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealsApp
{
    public partial class Filter: UserControl
    {
		private Action<string> onSearch;

        public Filter()
        {
            InitializeComponent();

			cbSearchBy.SelectedIndex = 0;
        }

		private void tbSearch_KeyPress(object sender, KeyPressEventArgs e)
		{

			if (string.IsNullOrEmpty(tbSearch.Text) && char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
			}

			else if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
			{
				e.Handled = true;
			}

			else e.Handled = false;
		}


		private void tbSearch_TextChanged(object sender, EventArgs e)
		{
			onSearch?.Invoke(tbSearch.Text);
		}

		public void Clear()
		{
			tbSearch.Text = "";

			tbSearch.Focus();
		}


		public void OnSearch(Action<string> OnSearch)
		{
			this.onSearch = OnSearch;
		}
	}
}
