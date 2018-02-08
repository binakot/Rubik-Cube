using Assets.Scripts.Utility;
using UnityEngine;

namespace Assets.Scripts
{
    public class Application : Singleton<Application>
    {
        private void Start()
        {
            Debug.Log("Start");
        }
    }
}
