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
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
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

        [Test]
        public void RotateUpClockwise()
        {
            var cube = new Cube();
            cube.RotateUpClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.BLUE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateUpCounterClockwise()
        {
            var cube = new Cube();
            cube.RotateUpCounterClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.BLUE);
            Assert.AreEqual(cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.RED);
            Assert.AreEqual(cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.RED);
            Assert.AreEqual(cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color, Colors.RED);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.BLUE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateLeftClockwise()
        {
            var cube = new Cube();
            cube.RotateLeftClockwise();

            // Up edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.RED, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.RED, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateLeftCounterClockwise()
        {
            var cube = new Cube();
            cube.RotateLeftCounterClockwise();

            // Up edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.RED, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.RED, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateFrontClockwise()
        {
            var cube = new Cube();
            cube.RotateFrontClockwise();

            // Up edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.BLUE, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateFrontCounterClockwise()
        {
            var cube = new Cube();
            cube.RotateFrontCounterClockwise();

            // Up edge
            Assert.AreEqual(Colors.BLUE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateRightClockwise()
        {
            var cube = new Cube();
            cube.RotateRightClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.RED, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.RED, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateRightCounterClockwise()
        {
            var cube = new Cube();
            cube.RotateRightCounterClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.RED, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.RED, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateBackClockwise()
        {
            var cube = new Cube();
            cube.RotateBackClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.BLUE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateBackCounterClockwise()
        {
            var cube = new Cube();
            cube.RotateBackCounterClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.BLUE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateDownClockwise()
        {
            var cube = new Cube();
            cube.RotateDownClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.ORANGE, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.RED, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.BLUE, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateDownCounterClockwise()
        {
            var cube = new Cube();
            cube.RotateDownCounterClockwise();

            // Up edge
            Assert.AreEqual(Colors.WHITE, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);
            Assert.AreEqual(Colors.WHITE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.UP).Color);

            // Left edge
            Assert.AreEqual(Colors.RED, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 1, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.LEFT).Color);

            // Front edge
            Assert.AreEqual(Colors.BLUE, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.BLUE, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[0, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[1, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);
            Assert.AreEqual(Colors.RED, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.FRONT).Color);

            // Right edge
            Assert.AreEqual(Colors.ORANGE, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 0, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 1, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);
            Assert.AreEqual(Colors.BLUE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.RIGHT).Color);

            // Back edge
            Assert.AreEqual(Colors.GREEN, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.GREEN, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.GREEN, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 1].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[0, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[1, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);
            Assert.AreEqual(Colors.ORANGE, cube[2, 2, 2].Stickers.First(s => s.Face == Faces.BACK).Color);

            // Down edge
            Assert.AreEqual(Colors.YELLOW, cube[0, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 0, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 1, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[0, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[1, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
            Assert.AreEqual(Colors.YELLOW, cube[2, 2, 0].Stickers.First(s => s.Face == Faces.DOWN).Color);
        }

        [Test]
        public void RotateClockwiseAndBack()
        {
            var cube = new Cube();
            var origin = cube.ToString();

            cube.RotateUpClockwise();
            cube.RotateUpCounterClockwise();
            Assert.AreEqual(origin, cube.ToString());

            cube.RotateLeftClockwise();
            cube.RotateLeftCounterClockwise();
            Assert.AreEqual(origin, cube.ToString());

            cube.RotateFrontClockwise();
            cube.RotateFrontCounterClockwise();
            Assert.AreEqual(origin, cube.ToString());

            cube.RotateRightClockwise();
            cube.RotateRightCounterClockwise();
            Assert.AreEqual(origin, cube.ToString());

            cube.RotateBackClockwise();
            cube.RotateBackCounterClockwise();
            Assert.AreEqual(origin, cube.ToString());

            cube.RotateDownClockwise();
            cube.RotateDownCounterClockwise();
            Assert.AreEqual(origin, cube.ToString());
        }
    }
}
