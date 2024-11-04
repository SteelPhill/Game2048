using Game2048.Database;
using Game2048.Entities;
using System;
using System.Collections.Generic;

namespace Game2048;

public static class Program
{
	[STAThread]
	public static void Main()
	{
        Locator.Current.Locate<App>().Run();
	}
}