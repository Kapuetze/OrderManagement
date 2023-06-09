using Microsoft.EntityFrameworkCore;
using OrderManagement.Core.DataLayer;

	public class BaseTest : IDisposable
	{
	protected ApplicationContext _dbContext;
	public BaseTest()
	{
		var myDatabaseName = "mydatabase_"+DateTime.Now.ToFileTimeUtc();

		var options = new DbContextOptionsBuilder<ApplicationContext>()
			.UseInMemoryDatabase(databaseName: myDatabaseName )
			.Options;

		_dbContext = new ApplicationContext(options);
	}

	public void Dispose()
	{
		_dbContext.Dispose();
	}
}