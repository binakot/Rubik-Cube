using System;
using Assets.Scripts.Core.Model;
using Assets.Scripts.Core.Model.Enums;
using Assets.Scripts.Utility;
using UnityEngine;

namespace Assets.Scripts
{
    [Serializable]
    public sealed class Application : Singleton<Application>
    {
        private Cube cube;

        private void Start()
        {
            cube = new Cube();
            Debug.Log(cube);
            cube.Rotate(Faces.UP, true);
            Debug.Log(cube);
            cube.Rotate(Faces.UP, false);
            Debug.Log(cube);
        }
    }
}
