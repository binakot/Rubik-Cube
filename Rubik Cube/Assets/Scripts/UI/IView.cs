using System;
using Assets.Scripts.Core.Model;
using Assets.Scripts.Core.Model.Enums;
using Assets.Scripts.UI.Events;

namespace Assets.Scripts.UI
{
    public interface IView
    {
        event EventHandler<CubeSideDraggedEventArgs> OnCubeSideDragged;

        void Render(Piece[,,] pieces);
        void Rotate(Faces face, bool clockwise);
        void Solved();
    }
}
