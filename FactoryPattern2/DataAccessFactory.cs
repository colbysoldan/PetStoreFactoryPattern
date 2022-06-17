using System;
namespace FactoryPattern2
{
	public static class DataAccessFactory
	{
		public static IDataAccess GetDataAccessType(string databaseType)
        {
			switch(databaseType.ToLower())
            {
				case "list":
				case "l":
					return new ListDataAccess();
				case "sql":
				case "s":
					return new SQLDataAccess();
				case "mongo":
				case "m":
					return new MongoDataAccess();
                default:
					return new ListDataAccess();
            }
        }
	}
}

