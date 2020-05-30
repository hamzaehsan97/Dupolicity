<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEditor;

namespace UnityEditor.U2D
{
    internal class SpriteShapeEditorAnalytics : ScriptableSingleton<SpriteShapeEditorAnalytics>
    {
        SpriteShapeAnalytics m_Analytics = null;

        internal SpriteShapeAnalyticsEvents eventBus
        {
            get { return analytics.eventBus; }
        }

        private SpriteShapeAnalytics analytics
        {
            get
            {
                if (m_Analytics == null)
                    m_Analytics = new SpriteShapeAnalytics(new SpriteShapeUnityAnalyticsStorage());
                
                return m_Analytics;
            }
        }
    }
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEditor;

namespace UnityEditor.U2D
{
    internal class SpriteShapeEditorAnalytics : ScriptableSingleton<SpriteShapeEditorAnalytics>
    {
        SpriteShapeAnalytics m_Analytics = null;

        internal SpriteShapeAnalyticsEvents eventBus
        {
            get { return analytics.eventBus; }
        }

        private SpriteShapeAnalytics analytics
        {
            get
            {
                if (m_Analytics == null)
                    m_Analytics = new SpriteShapeAnalytics(new SpriteShapeUnityAnalyticsStorage());
                
                return m_Analytics;
            }
        }
    }
}
>>>>>>> b39c852c342acbba552dd43c7adf66274a2a43b0
