/*
 *  Title: ""项目
 *
 *	Description:
 *
 *	Author:
 *
 *	Date:
 *
 *	Modify:
 * 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityGameFramework.Runtime;

namespace Paige
{
    public class UGUIUiGroupHelper : UIGroupHelperBase
    {
        public const int DepthFactor = 100;
        private int m_depth = 0;
        private Canvas m_CacheCanvas;
        public override void SetDepth(int depth)
        {
            m_depth = depth;
            //m_CacheCanvas.overrideSorting = true;
            m_CacheCanvas.sortingOrder = m_depth * DepthFactor;
        }

        private void Awake()
        {
            m_CacheCanvas = gameObject.GetOrAddComponent<Canvas>();
            gameObject.GetOrAddComponent<GraphicRaycaster>();
        }
        // Start is called before the first frame update
        void Start()
        {
            m_CacheCanvas.overrideSorting = true;
            m_CacheCanvas.sortingOrder = m_depth * DepthFactor;

            RectTransform rectTransform = GetComponent<RectTransform>();
            rectTransform.anchorMin = Vector2.zero;
            rectTransform.anchorMax = Vector2.zero;
            rectTransform.anchoredPosition = Vector2.zero;
            rectTransform.sizeDelta = Vector2.zero;
        }
    }
}

