using System.Data.Entity;

namespace JW_ScaffoldEnhancement.Data
{
	public class DataManagerContext : DbContext
	{
		public DataManagerContext()
		{ }

		public System.Data.Entity.DbSet<JW_ScaffoldEnhancement.Models.Product> Products { get; set; }

	}
}