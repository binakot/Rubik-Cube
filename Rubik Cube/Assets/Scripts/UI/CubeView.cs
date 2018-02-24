using System;
using System.Collections.Generic;
using Assets.Scripts.Core.Model;
using Assets.Scripts.Core.Model.Enums;
using Assets.Scripts.UI.Events;
using UnityEngine;

namespace Assets.Scripts.UI
{
    [Serializable]
    [DisallowMultipleComponent]
    public sealed class CubeView : MonoBehaviour, IView
    {
        public event EventHandler<CubeSideDraggedEventArgs> OnCubeSideDragged = (sender, e) => { };

        public void Render(Piece[,,] pieces)
        {
            RemovePieces(); // TODO Don't re-create pieces every update. Replace already existed pieces. Also add rotate animation.

            for (var x = 0; x < pieces.GetLength(0); x++)
                for (var y = 0; y < pieces.GetLength(1); y++)
                    for (var z = 0; z < pieces.GetLength(2); z++)
                        InstantiatePiece(x, y, z, pieces[x, y, z].Stickers);

            Debug.Log("Rendered");
        }

        public void Rotate(Faces face, bool clockwise)
        {
            Debug.Log($"Rotate {face} {(clockwise ? "clockwise" : "counterclockwise")}");

            OnCubeSideDragged(this, new CubeSideDraggedEventArgs(face, clockwise));
        }

        public void Solved()
        {
            Debug.Log("Solved");
        }

        private void RemovePieces()
        {
            foreach (Transform child in this.transform)
                GameObject.Destroy(child.gameObject);
        }

        private void InstantiatePiece(int x, int y, int z, IEnumerable<Sticker> stickers)
        {
            var go = (GameObject)Instantiate(Application.Instance.Resources.Piece);
            go.name = $"Piece {x} {y} {z}";
            go.transform.parent = this.transform;
            go.transform.localPosition = new Vector3(x, z, y);

            var colorBox = go.GetComponent<ColorBox>();
            foreach (var sticker in stickers)
            {
                switch (sticker.Face)
                {
                    case Faces.FRONT:
                        colorBox.FrontSideRenderer.material.color = sticker.Color.ToUnityColor();
                        break;
                    case Faces.BACK:
                        colorBox.BackSideRenderer.material.color = sticker.Color.ToUnityColor();
                        break;
                    case Faces.UP:
                        colorBox.UpSideRenderer.material.color = sticker.Color.ToUnityColor();
                        break;
                    case Faces.DOWN:
                        colorBox.DownSideRenderer.material.color = sticker.Color.ToUnityColor();
                        break;
                    case Faces.LEFT:
                        colorBox.LeftSideRenderer.material.color = sticker.Color.ToUnityColor();
                        break;
                    case Faces.RIGHT:
                        colorBox.RightSideRenderer.material.color = sticker.Color.ToUnityColor();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }
        }
    }
}
