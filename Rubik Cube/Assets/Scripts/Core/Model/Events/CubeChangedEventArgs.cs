using System;

namespace Assets.Scripts.Core.Model.Events
{
    [Serializable]
    public sealed class CubeChangedEventArgs : EventArgs
    {
        public Piece[,,] Pieces { get; }

        public CubeChangedEventArgs(Piece[,,] pieces)
        {
            Pieces = pieces;
        }
    }
}
