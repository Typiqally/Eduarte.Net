using System;
using System.Collections.Generic;

namespace Eduarte.Net.Rest.Builders
{
	public class AppointmentsFilterBuilder : IAppointmentsFilterBuilder
	{
		private readonly Dictionary<string, string> _parameters = new Dictionary<string, string>();

		public IAppointmentsFilterBuilder After(DateTime afterDateTime)
		{
			_parameters["beginDatumTijdAfter"] = afterDateTime.ToString("s");
			return this;
		}

		public IAppointmentsFilterBuilder Before(DateTime beforeDateTime)
		{
			_parameters["beginDatumTijdBefore"] = beforeDateTime.ToString("s");
			return this;
		}

		public IAppointmentsFilterBuilder AddAdditional(string additional)
		{
			_parameters["additional"] = additional;
			return this;
		}

		public IAppointmentsFilterBuilder SortBy(string sort)
		{
			_parameters["sort"] = sort;
			return this;
		}

		public AppointmentsFilter Build()
		{
			return new AppointmentsFilter(_parameters);
		}
	}
}