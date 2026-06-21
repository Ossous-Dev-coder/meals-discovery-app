namespace MealAppBusiness.Classes.Services
{
	public class CancelationService
	{
		static public bool LoadingThumbsCancelionRequisted { get; set; }

		static public void CancelLoadingThumbs()
		{
			LoadingThumbsCancelionRequisted = true;
		}
	}
}
