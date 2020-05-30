<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestStartedMessage : Message
    {
        public string name;
        public TestState state;

        public TestStartedMessage()
        {
            type = "TestStatus";
            phase = "Begin";
            state = TestState.Inconclusive;
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestStartedMessage : Message
    {
        public string name;
        public TestState state;

        public TestStartedMessage()
        {
            type = "TestStatus";
            phase = "Begin";
            state = TestState.Inconclusive;
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
