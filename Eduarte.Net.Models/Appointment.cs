using System;
using System.Text.Json.Serialization;

namespace Eduarte.Net.Models
{
	public class Appointment
	{
		[JsonPropertyName("links")]
		public Link[] Links { get; set; }

		[JsonPropertyName("permissions")]
		public Permission[] Permissions { get; set; }
		
		[JsonPropertyName("titel")]
		public string Title { get; set; }

		[JsonPropertyName("beginDatumTijd")]
		public DateTimeOffset StartDateTime { get; set; }

		[JsonPropertyName("eindDatumTijd")]
		public DateTimeOffset EndDateTime { get; set; }

		[JsonPropertyName("omschrijving")]
		public string Description { get; set; }

		[JsonPropertyName("afspraakLocatie")]
		public string Location { get; set; }

		[JsonPropertyName("participanten")]
		public Participant[] Participants { get; set; }

		[JsonPropertyName("afspraakType")]
		public AppointmentType Type { get; set; }

		[JsonPropertyName("beginLesuur")]
		public int StartClassHour { get; set; }

		[JsonPropertyName("eindLesuur")]
		public int EndClassHour { get; set; }

		[JsonPropertyName("presentieRegistratieVerplicht")]
		public bool IsAttendanceMandatory { get; set; }

		[JsonPropertyName("presentieRegistratieVerwerktOp")]
		public DateTimeOffset AttendanceRegistrationProcessedAt { get; set; }

		[JsonPropertyName("presentieRegistratieDeadline")]
		public DateTimeOffset AttendanceRegistrationDeadline { get; set; }

		[JsonPropertyName("externId")]
		public string ExternalId { get; set; }
	}
}