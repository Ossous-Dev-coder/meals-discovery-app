using System.Collections.Generic;

namespace MealAppBusiness.Classes
{
    public class DataStore
    {
         public List<Category> categories = new List<Category>();

         public List<Meal> meals = new List<Meal>();


        public DataStore()
        {
			categories = new List<Category>();

            meals = new List<Meal>();
	    }

    }
}
