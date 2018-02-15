using System;
using Assets.Scripts.Core.Model;
using Assets.Scripts.Core.Model.Enums;
using Assets.Scripts.Storages;
using Assets.Scripts.UI.Events;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Assets.Scripts.UI
{
    [Serializable]
    [DisallowMultipleComponent]
    public sealed class CubeView : MonoBehaviour, IView
    {
        public event EventHandler<CubeSideDraggedEventArgs> OnCubeSideDragged = (sender, e) => { };

        public void Render(Piece[,,] pieces)
        {
            Debug.Log("Render");

            var go = (GameObject) Instantiate(Application.Instance.Resources.Piece);
            go.transform.parent = this.transform;
            var renderers = go.GetComponentsInChildren<MeshRenderer>();
            foreach (var render in renderers)
            {
                render.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
            }
        }

        public void Rotate(Faces face, bool clockwise)
        {
            Debug.Log("Rotate");

            OnCubeSideDragged(this, new CubeSideDraggedEventArgs(face, clockwise));
        }

        public void Solved()
        {
            Debug.LogWarning("Cube is solved!");
        }
    }
}
