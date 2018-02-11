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
            Debug.Log(cube[0, 0, 0]);
        }
    }
}
