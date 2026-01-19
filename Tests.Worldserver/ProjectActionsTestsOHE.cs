using Tests.Worldserver.Base;
using Apps.Worldserver.Actions;
using Apps.Worldserver.Models.Projects.Request;

namespace Tests.Worldserver;

[TestClass]
public class ProjectActionsTestsOHE : TestBase
{
    [TestMethod]
    public async Task SearchProjects_ReturnsProjects()
    {
		// Arrange
		var actions = new ProjectActions(InvocationContext);
        var request = new GetProjectRequest { ProjectId= "442840" };

        // Act
        var result = await actions.GetProject(request);

        // Assert
        PrintJsonResult(result);
        Assert.IsNotNull(result);
    }
}
