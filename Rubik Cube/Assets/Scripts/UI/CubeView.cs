using System;
using Assets.Scripts.Core.Model;
using Assets.Scripts.Core.Model.Enums;
using Assets.Scripts.UI.Events;
using UnityEngine;

namespace Assets.Scripts.UI
{
    [Serializable]
    [DisallowMultipleComponent]
    public sealed class CubeView : MonoBehaviour
    {
        public event EventHandler<CubeSideDraggedEventArgs> OnCubeSideDragged = (sender, e) => { };

        public void Render(Piece[,,] pieces)
        {
            // TODO Render the magic cube.
        }

        public void ShowCubeSolvedText()
        {
            // TODO Show some text when cube will solved.
        }

        public void Rotate()
        {
            OnCubeSideDragged(this, new CubeSideDraggedEventArgs(Faces.UP, true)); // TODO Rotate cube's sides by mouse dragging or hotkeys.
        }
    }
}
