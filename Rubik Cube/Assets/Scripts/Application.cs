using System;
using Assets.Scripts.Core.Controllers;
using Assets.Scripts.Core.Model;
using Assets.Scripts.Core.Model.Enums;
using Assets.Scripts.Storages;
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
        [Header("Resource storage")]
        public ResourceStorage Resources;

        private CubeController controller;
        private CubeView view;

        private void Start()
        {
            view = this.GetComponent<CubeView>();
            controller = new CubeController(new Cube(), view);
            controller.ForceUpdate();
        }

        private void Update()
        {
            // TODO Rotate with mouse dragging.

            if (Input.GetKeyDown(KeyCode.F1))
                controller.ForceUpdate();

            if (Input.GetKeyDown(KeyCode.F))
                view.Rotate(Faces.FRONT, !Input.GetKey(KeyCode.LeftShift));
            if (Input.GetKeyDown(KeyCode.R))
                view.Rotate(Faces.RIGHT, !Input.GetKey(KeyCode.LeftShift));
            if (Input.GetKeyDown(KeyCode.U))
                view.Rotate(Faces.UP, !Input.GetKey(KeyCode.LeftShift));
            if (Input.GetKeyDown(KeyCode.B))
                view.Rotate(Faces.BACK, !Input.GetKey(KeyCode.LeftShift));
            if (Input.GetKeyDown(KeyCode.L))
                view.Rotate(Faces.LEFT, !Input.GetKey(KeyCode.LeftShift));
            if (Input.GetKeyDown(KeyCode.D))
                view.Rotate(Faces.DOWN, !Input.GetKey(KeyCode.LeftShift));
        }
    }
}
