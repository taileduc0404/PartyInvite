namespace PartyInvite_Tai.Models
{
	public class Responsitory
	{
		private static List<GuestResponse> responses = new List<GuestResponse>();
		public static IEnumerable<GuestResponse> Responses
		{
			get 
			{ 
				return responses; 
			}
		}
		public static void AddResponse(GuestResponse response)
		{
			responses.Add(response);
		}
	}
}
