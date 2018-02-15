using System;

namespace Assets.Scripts.Core.Model
{
    [Serializable]
    public sealed class EdgePiece : Piece
    {
        public EdgePiece(Sticker[] stickers) 
            : base(stickers)
        {
            if (stickers.Length != 2)
                throw new ArgumentException("Edge piece must contain 2 stickers");
        }
    }
}
