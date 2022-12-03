using System.ComponentModel.DataAnnotations;
using System;


namespace Passel.Models
{
	public class Media
	{
		public int MediaID { get; set; }
		public string MediaType { get; set; }
		public string MediaName { get; set; }
		public string MediaURL { get; set; }
	}
}