using Loging_Service;
using MealAppBusiness.Classes;

namespace MealsApp.Classes
{
	public static class App
	{
		readonly static public LoggingService ErrorsLoggingService = new LoggingService(new LogToEventsLog(Config.LoggingSource, "Application", System.Diagnostics.EventLogEntryType.Error));

		readonly static public LoggingService WarrningsLoggingService = new LoggingService(new LogToEventsLog(Config.LoggingSource, "Application", System.Diagnostics.EventLogEntryType.Warning));

		readonly static public DataStore dataStore = new DataStore();
	}
}
