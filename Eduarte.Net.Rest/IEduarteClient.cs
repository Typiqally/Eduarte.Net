using System.Collections.Generic;
using System.Threading.Tasks;
using Eduarte.Net.Models;

namespace Eduarte.Net.Rest
{
	public interface IEduarteClient
	{
		Task<List<Appointment>> RequestAppointmentsAsync(AppointmentsFilter filter = null);
		Task<PersonalUser> RequestCurrentUserAsync();
	}
}