using System;

namespace Assets.Scripts.Core.Model
{
    [Serializable]
    public sealed class CentralPiece : Piece
    {
        public CentralPiece(Sticker[] stickers) 
            : base(stickers)
        {
            if (stickers.Length != 1)
                throw new ArgumentException("Central piece must contain only 1 sticker");
        }
    }
}
