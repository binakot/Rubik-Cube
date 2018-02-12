using Assets.Scripts.Core.Model;
using Assets.Scripts.Utility;
using UnityEngine;

namespace Assets.Scripts
{
    public class Application : Singleton<Application>
    {
        private Cube cube;

        private void Start()
        {
            cube = new Cube();
            Debug.Log(cube);
            cube.RotateUpClockwise();
            Debug.Log(cube);
            cube.RotateUpCounterClockwise();
            Debug.Log(cube);
        }
    }
}
