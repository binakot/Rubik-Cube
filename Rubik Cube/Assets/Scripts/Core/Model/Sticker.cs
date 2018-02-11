using System;

namespace Assets.Scripts.Core.Model
{
    [Serializable]
    public sealed class Sticker
    {
        public Faces Face { get; private set; }
        public Colors Color { get; }

        public Sticker(Faces face, Colors color)
        {
            Face = face;
            Color = color;
        }

        public Sticker(Faces face)
        {
            Face = face;
            Color = (Colors) face;
        }

        public void PlaceOn(Faces newFace)
        {
            Face = newFace;
        }

        public override string ToString()
        {
            return $"{Face} {Color}";
        }
    }
}
