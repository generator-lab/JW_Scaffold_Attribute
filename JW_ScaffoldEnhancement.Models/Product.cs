using System;
using System.ComponentModel.DataAnnotations;

namespace JW_ScaffoldEnhancement.Models
{
public class Product : IControllerHooks
{
	public int ProductId { get; set; }
	public string Description { get; set; }
  // don't update the database context with posted-back data 
	[PersistPropertyOnEdit(false)]
  // don't show the CreatedDate on any of the views 
  [ScaffoldColumn(false)]
	public DateTime? CreatedDate { get; set; }
  // don't show field on the Create and Edit views
	[Editable(false)]
  // show field as a display (label) value that is not editable on only the Edit view
	[DisplayOnEditView(true)]
	public DateTime? ModifiedDate { get; set; }

		public void OnCreate()
		{
			this.CreatedDate = DateTime.UtcNow;
			this.ModifiedDate = this.CreatedDate;
		}

		public void OnEdit()
		{
			this.ModifiedDate = DateTime.UtcNow;
		}
	}
}