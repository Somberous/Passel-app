using System.ComponentModel.DataAnnotations;
using System;


namespace Passel.Models
{
	public class Change
	{
		public int ChangeID { get; set; }
		[Required(ErrorMessage = "Please Select a title")]
		public string ChangeType { get; set; }
		public string ChangeDescription { get; set; }
		public DateTime ChangeDate { get; set; }
		public string ChangeAuthor { get; set; }
	}
}