<<<<<<< HEAD
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal class SkinningSerializerJSON : ISkinningSerializer
    {
        public bool CanDeserialize(string data)
        {
            bool result = true;
            try
            {
                JsonUtility.FromJson<SkinningCopyData>(data);
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public SkinningCopyData Deserialize(string data)
        {
            return JsonUtility.FromJson<SkinningCopyData>(data);
        }

        public string Serialize(SkinningCopyData skinningData)
        {
            return JsonUtility.ToJson(skinningData);
        }
    }
}
=======
using UnityEngine;

namespace UnityEditor.U2D.Animation
{
    internal class SkinningSerializerJSON : ISkinningSerializer
    {
        public bool CanDeserialize(string data)
        {
            bool result = true;
            try
            {
                JsonUtility.FromJson<SkinningCopyData>(data);
            }
            catch
            {
                result = false;
            }
            return result;
        }

        public SkinningCopyData Deserialize(string data)
        {
            return JsonUtility.FromJson<SkinningCopyData>(data);
        }

        public string Serialize(SkinningCopyData skinningData)
        {
            return JsonUtility.ToJson(skinningData);
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
