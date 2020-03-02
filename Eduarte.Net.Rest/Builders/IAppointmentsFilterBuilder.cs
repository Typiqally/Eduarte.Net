using System;

namespace Eduarte.Net.Rest.Builders
{
	public interface IAppointmentsFilterBuilder
	{
		IAppointmentsFilterBuilder After(DateTime afterDateTime);
		IAppointmentsFilterBuilder Before(DateTime beforeDateTime);
		IAppointmentsFilterBuilder AddAdditional(string additional);
		IAppointmentsFilterBuilder SortBy(string sort);
		AppointmentsFilter Build();
	}
}