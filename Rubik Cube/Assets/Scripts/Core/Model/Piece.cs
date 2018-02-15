using System;

namespace Assets.Scripts.Core.Model
{
    [Serializable]
    public abstract class Piece
    {
        public Sticker[] Stickers { get; }

        protected Piece(Sticker[] stickers)
        {
            Stickers = stickers;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} ({string.Join<Sticker>(", ", Stickers)})";
        }
    }
}
