using OrderManagement.Core.ApplicationLogic.Accounts;
using OrderManagement.Core.Models;

namespace OrderManagement.Core.Tests.ApplicationLayer.Organisations;

public class OrganisationLogicTests : BaseTest
{
    OrganisationLogic _organisationLogic;

	public OrganisationLogicTests()
	{
		_organisationLogic = new OrganisationLogic(_dbContext);
	}

    [Fact]
    public async Task ValidOrganisationIsInserted()
    {
        var newOrganisation = new Organisation
        {
			Name = "Test",
			Contact = new Contact()
			{
				FirstName = "FirstName",
				LastName = "LastName",
				City = "City",
				State = "State",
				Country = "Country",
			}
        };
        await _organisationLogic.Create(newOrganisation);

		var inserted = _dbContext.Organisations.Find(1);
		Assert.Equivalent(newOrganisation, inserted);
    }
}