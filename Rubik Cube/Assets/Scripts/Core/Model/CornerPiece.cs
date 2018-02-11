using System;

namespace Assets.Scripts.Core.Model
{
    [Serializable]
    public sealed class CornerPiece : Piece
    {
        public CornerPiece(Sticker[] stickers) 
            : base(stickers)
        {
            if (stickers.Length != 3)
                throw new ArgumentException("Corner piece must contain 3 stickers");
        }
    }
}
