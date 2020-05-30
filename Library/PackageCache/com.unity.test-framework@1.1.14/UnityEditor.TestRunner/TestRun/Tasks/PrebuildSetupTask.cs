<<<<<<< HEAD
using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class PrebuildSetupTask : BuildActionTaskBase<IPrebuildSetup>
    {
        public PrebuildSetupTask() : base(new PrebuildSetupAttributeFinder())
        {
        }

        protected override void Action(IPrebuildSetup target)
        {
            target.Setup();
        }
    }
=======
using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class PrebuildSetupTask : BuildActionTaskBase<IPrebuildSetup>
    {
        public PrebuildSetupTask() : base(new PrebuildSetupAttributeFinder())
        {
        }

        protected override void Action(IPrebuildSetup target)
        {
            target.Setup();
        }
    }
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
}