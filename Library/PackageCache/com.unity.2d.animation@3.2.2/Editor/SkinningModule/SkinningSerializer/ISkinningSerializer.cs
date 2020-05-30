<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;


namespace UnityEditor.U2D.Animation
{
    internal interface ISkinningSerializer
    {
        bool CanDeserialize(string data);
        SkinningCopyData Deserialize(string data);
        string Serialize(SkinningCopyData skinningData);
    }

    [Serializable]
    internal class SpriteBoneCopyData
    {
        public UnityEngine.U2D.SpriteBone spriteBone;
        public int order;
    }

    [Serializable]
    internal class SkinningCopySpriteData
    {
        public string spriteName;
        public List<SpriteBoneCopyData> spriteBones;
        public List<Vertex2D> vertices;
        public List<int> indices;
        public List<Edge> edges;
        public List<string> boneWeightNames;
    }

    [Serializable]
    internal class SkinningCopyData
    {
        public float pixelsPerUnit;
        public List<SkinningCopySpriteData> copyData = new List<SkinningCopySpriteData>();
    }
}
=======
﻿using System;
using System.Collections.Generic;


namespace UnityEditor.U2D.Animation
{
    internal interface ISkinningSerializer
    {
        bool CanDeserialize(string data);
        SkinningCopyData Deserialize(string data);
        string Serialize(SkinningCopyData skinningData);
    }

    [Serializable]
    internal class SpriteBoneCopyData
    {
        public UnityEngine.U2D.SpriteBone spriteBone;
        public int order;
    }

    [Serializable]
    internal class SkinningCopySpriteData
    {
        public string spriteName;
        public List<SpriteBoneCopyData> spriteBones;
        public List<Vertex2D> vertices;
        public List<int> indices;
        public List<Edge> edges;
        public List<string> boneWeightNames;
    }

    [Serializable]
    internal class SkinningCopyData
    {
        public float pixelsPerUnit;
        public List<SkinningCopySpriteData> copyData = new List<SkinningCopySpriteData>();
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
