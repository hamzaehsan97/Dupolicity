<<<<<<< HEAD
using Unity.Collections;
using UnityEngine;

namespace PDNWrapper
{
    internal class Surface
    {
        NativeArray<Color32> m_Color;
        public Surface(int w, int h)
        {
            width = w;
            height = h;
            m_Color = new NativeArray<Color32>(width * height, Allocator.Persistent);
        }

        public void Dispose()
        {
            m_Color.Dispose();
        }

        public NativeArray<Color32> color
        {
            get { return m_Color; }
        }

        public int width { get; private set; }
        public int height { get; private set; }
    }
}
=======
using Unity.Collections;
using UnityEngine;

namespace PDNWrapper
{
    internal class Surface
    {
        NativeArray<Color32> m_Color;
        public Surface(int w, int h)
        {
            width = w;
            height = h;
            m_Color = new NativeArray<Color32>(width * height, Allocator.Persistent);
        }

        public void Dispose()
        {
            m_Color.Dispose();
        }

        public NativeArray<Color32> color
        {
            get { return m_Color; }
        }

        public int width { get; private set; }
        public int height { get; private set; }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
