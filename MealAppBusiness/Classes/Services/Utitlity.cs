
namespace MealAppBusiness.Classes
{
	public static class Utitlity
	{
		public static bool IsAllWhiteSpace(string text)
		{
			foreach (char c in text)
			{
				if (c != ' ')
				{
					return false;
				}

			}
				
			return true;
		}


	}
}
