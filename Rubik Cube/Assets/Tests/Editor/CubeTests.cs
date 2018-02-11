using System.Linq;
using Assets.Scripts.Core.Model;
using NUnit.Framework;

namespace Assets.Tests.Editor
{
    public sealed class CubeTests
    {
        [Test]
        public void CreateSolvedCubeAndTestAllStickers()
        {
            var cube = new Cube();

            // Up edge
            Assert.AreEqual(cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);
            Assert.AreEqual(cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color, Colors.WHITE);

            // Left edge
            Assert.AreEqual(cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);
            Assert.AreEqual(cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color, Colors.GREEN);

            // Front edge
            Assert.AreEqual(cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);
            Assert.AreEqual(cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color, Colors.RED);

            // Right edge
            Assert.AreEqual(cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);

            // Back edge
            Assert.AreEqual(cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);
            Assert.AreEqual(cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color, Colors.ORANGE);

            // Down edge
            Assert.AreEqual(cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
            Assert.AreEqual(cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color, Colors.YELLOW);
        }

        [Test]
        public void CreateSolvedCubeAndTestAllCentralPieces()
        {
            var cube = new Cube();

            Assert.IsTrue(TestPiece(cube[1, 1, 2], Faces.UP, 1));
            Assert.IsTrue(TestPiece(cube[0, 1, 1], Faces.LEFT, 1));
            Assert.IsTrue(TestPiece(cube[1, 0, 1], Faces.FRONT, 1));
            Assert.IsTrue(TestPiece(cube[2, 1, 1], Faces.RIGHT, 1));
            Assert.IsTrue(TestPiece(cube[1, 2, 1], Faces.BACK, 1));
            Assert.IsTrue(TestPiece(cube[1, 1, 0], Faces.DOWN, 1));
        }

        [Test]
        public void CreateSolvedCubeAndTestAllEdgePieces()
        {
            var cube = new Cube();

            Assert.IsTrue(TestPiece(cube[1, 0, 2], Faces.UP, 2));
            Assert.IsTrue(TestPiece(cube[0, 1, 2], Faces.UP, 2));
            Assert.IsTrue(TestPiece(cube[1, 2, 2], Faces.UP, 2));
            Assert.IsTrue(TestPiece(cube[2, 1, 2], Faces.UP, 2));

            Assert.IsTrue(TestPiece(cube[0, 0, 1], Faces.LEFT, 2));
            Assert.IsTrue(TestPiece(cube[0, 1, 0], Faces.LEFT, 2));
            Assert.IsTrue(TestPiece(cube[0, 2, 1], Faces.LEFT, 2));
            Assert.IsTrue(TestPiece(cube[0, 1, 2], Faces.LEFT, 2));

            Assert.IsTrue(TestPiece(cube[1, 0, 0], Faces.FRONT, 2));
            Assert.IsTrue(TestPiece(cube[0, 0, 1], Faces.FRONT, 2));
            Assert.IsTrue(TestPiece(cube[1, 0, 2], Faces.FRONT, 2));
            Assert.IsTrue(TestPiece(cube[2, 0, 1], Faces.FRONT, 2));

            Assert.IsTrue(TestPiece(cube[2, 0, 1], Faces.RIGHT, 2));
            Assert.IsTrue(TestPiece(cube[2, 1, 0], Faces.RIGHT, 2));
            Assert.IsTrue(TestPiece(cube[2, 2, 1], Faces.RIGHT, 2));
            Assert.IsTrue(TestPiece(cube[2, 1, 2], Faces.RIGHT, 2));

            Assert.IsTrue(TestPiece(cube[1, 2, 0], Faces.BACK, 2));
            Assert.IsTrue(TestPiece(cube[0, 2, 1], Faces.BACK, 2));
            Assert.IsTrue(TestPiece(cube[1, 2, 2], Faces.BACK, 2));
            Assert.IsTrue(TestPiece(cube[2, 2, 1], Faces.BACK, 2));

            Assert.IsTrue(TestPiece(cube[1, 0, 0], Faces.DOWN, 2));
            Assert.IsTrue(TestPiece(cube[0, 1, 0], Faces.DOWN, 2));
            Assert.IsTrue(TestPiece(cube[1, 2, 0], Faces.DOWN, 2));
            Assert.IsTrue(TestPiece(cube[2, 1, 0], Faces.DOWN, 2));
        }

        [Test]
        public void CreateSolvedCubeAndTestAllCornerPieces()
        {
            var cube = new Cube();

            Assert.IsTrue(TestPiece(cube[0, 0, 2], Faces.UP, 3));
            Assert.IsTrue(TestPiece(cube[0, 2, 2], Faces.UP, 3));
            Assert.IsTrue(TestPiece(cube[2, 2, 2], Faces.UP, 3));
            Assert.IsTrue(TestPiece(cube[2, 0, 2], Faces.UP, 3));

            Assert.IsTrue(TestPiece(cube[0, 0, 0], Faces.LEFT, 3));
            Assert.IsTrue(TestPiece(cube[0, 2, 0], Faces.LEFT, 3));
            Assert.IsTrue(TestPiece(cube[0, 2, 2], Faces.LEFT, 3));
            Assert.IsTrue(TestPiece(cube[0, 0, 2], Faces.LEFT, 3));

            Assert.IsTrue(TestPiece(cube[0, 0, 0], Faces.FRONT, 3));
            Assert.IsTrue(TestPiece(cube[0, 0, 2], Faces.FRONT, 3));
            Assert.IsTrue(TestPiece(cube[2, 0, 0], Faces.FRONT, 3));
            Assert.IsTrue(TestPiece(cube[2, 0, 2], Faces.FRONT, 3));

            Assert.IsTrue(TestPiece(cube[2, 0, 0], Faces.RIGHT, 3));
            Assert.IsTrue(TestPiece(cube[2, 2, 0], Faces.RIGHT, 3));
            Assert.IsTrue(TestPiece(cube[2, 2, 2], Faces.RIGHT, 3));
            Assert.IsTrue(TestPiece(cube[2, 0, 2], Faces.RIGHT, 3));

            Assert.IsTrue(TestPiece(cube[0, 2, 0], Faces.BACK, 3));
            Assert.IsTrue(TestPiece(cube[0, 2, 2], Faces.BACK, 3));
            Assert.IsTrue(TestPiece(cube[2, 2, 0], Faces.BACK, 3));
            Assert.IsTrue(TestPiece(cube[2, 2, 2], Faces.BACK, 3));

            Assert.IsTrue(TestPiece(cube[0, 0, 0], Faces.DOWN, 3));
            Assert.IsTrue(TestPiece(cube[0, 2, 0], Faces.DOWN, 3));
            Assert.IsTrue(TestPiece(cube[2, 2, 0], Faces.DOWN, 3));
            Assert.IsTrue(TestPiece(cube[2, 0, 0], Faces.DOWN, 3));
        }

        private static bool TestPiece(Piece piece, Faces face, int requiredStickerCount)
        {
            return piece.Stickers.Contains(new Sticker(face)) && piece.Stickers.Length == requiredStickerCount;
        }
    }
}
