using System;
using Assets.Scripts.Core.Controllers;
using Assets.Scripts.Core.Model;
using Assets.Scripts.UI;
using Assets.Scripts.Utility;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(CubeView))]
    public sealed class Application : Singleton<Application>
    {
        private CubeController controller;

        private void Start()
        {
            controller = new CubeController(new Cube(), this.GetComponent<CubeView>());
        }
    }
}
