using System.Collections.Generic;
using System.Linq;

namespace Eduarte.Net.Models.Extensions
{
	public static class AppointmentExtensions
	{
		public static IEnumerable<Teacher> GetTeachers(this Appointment appointment)
		{
			return appointment.Participants.Select(x => x.Teacher);
		}
		
		public static IEnumerable<Group> GetGroups(this Appointment appointment)
		{
			return appointment.Participants.Select(x => x.Group);
		}
	}
}