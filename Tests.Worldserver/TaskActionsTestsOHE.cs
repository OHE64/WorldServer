using Tests.Worldserver.Base;
using Apps.Worldserver.Actions;
using Apps.Worldserver.Models.Tasks.Request;

namespace Tests.Worldserver;

[TestClass]
public class TaskActionsTestsOHE : TestBase
{
    [TestMethod]
    public async Task GetTask_ReturnsTask()
    {
        var actions = new TaskActions(InvocationContext, null!);

        var request = new GetTaskRequest 
        { 
            TaskId = "2694497" 
        };

        var result = await actions.GetTask(request);

        PrintJsonResult(result);
        Assert.IsNotNull(result);

        // Falls du weißt, welche Felder zurückkommen sollen:
        // Assert.AreEqual("2694497", result.Id);
    }
}
