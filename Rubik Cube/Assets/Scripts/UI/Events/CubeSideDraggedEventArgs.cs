using System;
using Assets.Scripts.Core.Model.Enums;

namespace Assets.Scripts.UI.Events
{
    [Serializable]
    public sealed class CubeSideDraggedEventArgs : EventArgs
    {
        public Faces Face { get; }
        public bool Clockwise { get; }

        public CubeSideDraggedEventArgs(Faces face, bool clockwise)
        {
            Face = face;
            Clockwise = clockwise;
        }
    }
}
