using System;
using UnityEngine;

namespace Assets.Scripts.Storages
{
    [Serializable]
    [CreateAssetMenu(fileName = "Resources", menuName = "Storages/Resources")]
    public sealed class ResourceStorage : ScriptableObject
    {
        [Header("Piece Prefab")]
        public GameObject Piece;
    }
}
