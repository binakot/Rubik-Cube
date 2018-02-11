using System;

namespace Assets.Scripts.Core.Model
{
    [Serializable]
    public class EmptyPiece : Piece
    {
        public EmptyPiece() 
            : base(Array.Empty<Sticker>())
        {
            if (Stickers.Length != 0)
                throw new ArgumentException("Internal piece has no stickers. It is inside the cube.");
        }
    }
}