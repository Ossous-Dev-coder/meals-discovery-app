using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MealsApp.Classes;

namespace MealsApp.UI_Elements
{
    public partial class NoInternetCrtl: UserControl
    {
        Action Retry;

        public NoInternetCrtl()
        {
            InitializeComponent();
        }

        public NoInternetCrtl(Action OnRetry) : 
            this()
        {
			InitializeComponent();

			Dock = DockStyle.Fill;

			Retry = OnRetry;
        }

		private async void btnRetry_Click(object sender, EventArgs e)
		{
            if(await InternetService.CheckForConnection())

                Retry?.Invoke();

		}
	}
}
