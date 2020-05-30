<<<<<<< HEAD
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    [Serializable]
    internal class BoneSelection : SerializableSelection<BoneCache>, IBoneSelection
    {
        protected override BoneCache GetInvalidElement() { return null; }

        public BoneCache root
        {
            get { return activeElement.FindRoot<BoneCache>(elements); }
        }

        public BoneCache[] roots
        {
            get { return elements.FindRoots<BoneCache>(); }
        }
    }
}
=======
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    [Serializable]
    internal class BoneSelection : SerializableSelection<BoneCache>, IBoneSelection
    {
        protected override BoneCache GetInvalidElement() { return null; }

        public BoneCache root
        {
            get { return activeElement.FindRoot<BoneCache>(elements); }
        }

        public BoneCache[] roots
        {
            get { return elements.FindRoots<BoneCache>(); }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
