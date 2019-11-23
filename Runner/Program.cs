using System.Runtime.InteropServices;
using fitnesse.fitserver;
using fitSharp.IO;
using fitSharp.Machine.Engine;

namespace Runner
{
	public class Program
	{
		static int Main(string[] arguments)
		{
			FitServer fitServer = new FitServer();

			if (null != arguments && null != arguments[0] && !RuntimeInformation.IsOSPlatform(OSPlatform.Windows ))
			{
				arguments[0] = arguments[0].Replace(":", ";");
			}

			fitServer.Run(arguments, new TypeDictionary(), new ConsoleReporter());

			return 0;
		}
	}
}
