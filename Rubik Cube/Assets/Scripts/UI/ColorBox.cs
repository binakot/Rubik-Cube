using System;
using UnityEngine;

namespace Assets.Scripts.UI
{
    [Serializable]
    [DisallowMultipleComponent]
    public sealed class ColorBox : MonoBehaviour
    {
        [Header("Side Renderers")]
        public MeshRenderer FrontSideRenderer;
        public MeshRenderer BackSideRenderer;
        public MeshRenderer UpSideRenderer;
        public MeshRenderer DownSideRenderer;
        public MeshRenderer LeftSideRenderer;
        public MeshRenderer RightSideRenderer;
    }
}