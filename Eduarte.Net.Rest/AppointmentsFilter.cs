using System.Collections.Generic;

namespace Eduarte.Net.Rest
{
	public class AppointmentsFilter
	{
		internal AppointmentsFilter(Dictionary<string, string> parameters)
		{
			Parameters = parameters;
		}

		public Dictionary<string, string> Parameters { get; }
	}
}