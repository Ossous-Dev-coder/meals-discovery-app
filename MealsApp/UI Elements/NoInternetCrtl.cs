using System;
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
