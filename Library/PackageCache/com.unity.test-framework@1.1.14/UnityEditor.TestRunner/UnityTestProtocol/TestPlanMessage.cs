<<<<<<< HEAD
using System.Collections.Generic;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestPlanMessage : Message
    {
        public List<string> tests;

        public TestPlanMessage()
        {
            type = "TestPlan";
        }
    }
}
=======
using System.Collections.Generic;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestPlanMessage : Message
    {
        public List<string> tests;

        public TestPlanMessage()
        {
            type = "TestPlan";
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
