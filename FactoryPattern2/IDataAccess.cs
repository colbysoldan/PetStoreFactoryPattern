using System;
using System.Collections.Generic;

namespace FactoryPattern2
{
	public interface IDataAccess
	{
		//stubbed out methods
		List<Product> LoadData();
		public void SaveData();

	}
}

