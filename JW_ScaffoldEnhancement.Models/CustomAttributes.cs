using System;

namespace JW_ScaffoldEnhancement.Models
{
	public class DisplayOnEditView : Attribute
	{
		public readonly bool DisplayFlag;
		public DisplayOnEditView(bool displayFlag)
		{
			this.DisplayFlag = displayFlag;
		}
	}

	public class PersistPropertyOnEdit : Attribute
	{
		public readonly bool PersistPostbackDataFlag;
		public PersistPropertyOnEdit(bool persistPostbackDataFlag)
		{
			this.PersistPostbackDataFlag = persistPostbackDataFlag;
		}
	}
}
