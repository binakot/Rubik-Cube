using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Assets.Scripts.Core.Model
{
    /// <summary>
    /// 
    /// Y
    /// ^
    /// |  ------- ------- ------- 
    /// | | 0,2,Z | 1,2,Z | 2,2,Z |
    /// |  ------- ------- ------- 
    /// | | 0,1,Z | 1,1,Z | 2,1,Z |
    /// |  ------- ------- ------- 
    /// | | 0,0,Z | 1,0,Z | 2,0,Z |
    /// |  ------- ------- ------- 
    /// |---------------- > X
    /// 
    /// Z - layer's height
    ///
    /// </summary>
    public sealed class Cube
    {
        private readonly Piece[,,] _pieces = new Piece[3, 3, 3];

        public Piece this[int x, int y, int z] => _pieces[x, y, z];

        public Cube()
        {
            InitSolvedCube();
        }

        private void InitSolvedCube()
        {
            #region BOTTOM LAYER

            // First row
            _pieces[0, 0, 0] = new CornerPiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.DOWN), new Sticker(Faces.LEFT) });
            _pieces[1, 0, 0] = new EdgePiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.DOWN) });
            _pieces[2, 0, 0] = new CornerPiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.DOWN), new Sticker(Faces.RIGHT) });

            // Second row
            _pieces[0, 1, 0] = new EdgePiece(new[] { new Sticker(Faces.LEFT), new Sticker(Faces.DOWN) });
            _pieces[1, 1, 0] = new CentralPiece(new[] { new Sticker(Faces.DOWN) });
            _pieces[2, 1, 0] = new EdgePiece(new[] { new Sticker(Faces.RIGHT), new Sticker(Faces.DOWN) });

            // Third row
            _pieces[0, 2, 0] = new CornerPiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.DOWN), new Sticker(Faces.LEFT) });
            _pieces[1, 2, 0] = new EdgePiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.DOWN) });
            _pieces[2, 2, 0] = new CornerPiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.DOWN), new Sticker(Faces.RIGHT) });

            #endregion BOTTOM LAYER

            #region MIDDLE LAYER

            // First row
            _pieces[0, 0, 1] = new EdgePiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.LEFT) });
            _pieces[1, 0, 1] = new CentralPiece(new[] { new Sticker(Faces.FRONT) });
            _pieces[2, 0, 1] = new EdgePiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.RIGHT) });

            // Second row
            _pieces[0, 1, 1] = new CentralPiece(new[] { new Sticker(Faces.LEFT) });
            _pieces[1, 1, 1] = new EmptyPiece();
            _pieces[2, 1, 1] = new CentralPiece(new[] { new Sticker(Faces.RIGHT) });

            // Third row
            _pieces[0, 2, 1] = new EdgePiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.LEFT) });
            _pieces[1, 2, 1] = new CentralPiece(new[] { new Sticker(Faces.BACK) });
            _pieces[2, 2, 1] = new EdgePiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.RIGHT) });

            #endregion MIDDLE LAYER

            #region TOP LAYER

            // First row
            _pieces[0, 0, 2] = new CornerPiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.UP), new Sticker(Faces.LEFT) });
            _pieces[1, 0, 2] = new EdgePiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.UP) });
            _pieces[2, 0, 2] = new CornerPiece(new[] { new Sticker(Faces.FRONT), new Sticker(Faces.UP), new Sticker(Faces.RIGHT) });

            // Second row
            _pieces[0, 1, 2] = new EdgePiece(new[] { new Sticker(Faces.LEFT), new Sticker(Faces.UP) });
            _pieces[1, 1, 2] = new CentralPiece(new[] { new Sticker(Faces.UP) });
            _pieces[2, 1, 2] = new EdgePiece(new[] { new Sticker(Faces.RIGHT), new Sticker(Faces.UP) });

            // Third row
            _pieces[0, 2, 2] = new CornerPiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.UP), new Sticker(Faces.LEFT) });
            _pieces[1, 2, 2] = new EdgePiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.UP) });
            _pieces[2, 2, 2] = new CornerPiece(new[] { new Sticker(Faces.BACK), new Sticker(Faces.UP), new Sticker(Faces.RIGHT) });

            #endregion TOP LAYER
        }

        #region UP

        // U
        public void RotateUpClockwise()
        {
            SwapUpPieces(true);
        }

        // U'
        public void RotateUpCounterClockwise()
        {
            SwapUpPieces(false);
        }

        private void SwapUpPieces(bool clockwise)
        {
            var x = clockwise ? 2 : 0;
            var y = clockwise ? 0 : 2;

            // Corner pieces
            var temp = _pieces[0, 0, 2];
            _pieces[0, 0, 2] = _pieces[x, y, 2];
            _pieces[x, y, 2] = _pieces[2, 2, 2];
            _pieces[2, 2, 2] = _pieces[y, x, 2];
            _pieces[y, x, 2] = temp;

            // Edge pieces
            temp = _pieces[0, 1, 2];
            _pieces[0, 1, 2] = _pieces[1, y, 2];
            _pieces[1, y, 2] = _pieces[2, 1, 2];
            _pieces[2, 1, 2] = _pieces[1, x, 2];
            _pieces[1, x, 2] = temp;
            
            foreach (var piece in _pieces)
            {
                if (piece.Stickers.FirstOrDefault(s => s.Face == Faces.UP) == null)
                    continue;

                foreach (var sticker in piece.Stickers)
                {
                    if (sticker.Face == Faces.UP)
                        continue;

                    switch (sticker.Face)
                    {
                        case Faces.FRONT:
                            sticker.PlaceOn(clockwise ? Faces.LEFT : Faces.RIGHT);
                            break;
                        case Faces.BACK:
                            sticker.PlaceOn(clockwise ? Faces.RIGHT : Faces.LEFT);
                            break;
                        case Faces.LEFT:
                            sticker.PlaceOn(clockwise ? Faces.BACK : Faces.FRONT);
                            break;
                        case Faces.RIGHT:
                            sticker.PlaceOn(clockwise ? Faces.FRONT : Faces.BACK);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        #endregion UP

        #region LEFT

        // L
        public void RotateLeftClockwise()
        {
            SwapLeftPieces(true);
        }

        // L'
        public void RotateLeftCounterClockwise()
        {
            SwapLeftPieces(false);
        }

        private void SwapLeftPieces(bool clockwise)
        {
            var x = clockwise ? 2 : 0;
            var y = clockwise ? 0 : 2;

            // Corner pieces
            var temp = _pieces[0, 0, 0];
            _pieces[0, 0, 0] = _pieces[0, y, x];
            _pieces[0, y, x] = _pieces[0, 2, 2];
            _pieces[0, 2, 2] = _pieces[0, x, y];
            _pieces[0, x, y] = temp;

            // Edge pieces
            temp = _pieces[0, 0, 1];
            _pieces[0, 0, 1] = _pieces[0, 1, x];
            _pieces[0, 1, x] = _pieces[0, 2, 1];
            _pieces[0, 2, 1] = _pieces[0, 1, y];
            _pieces[0, 1, y] = temp;

            foreach (var piece in _pieces)
            {
                if (piece.Stickers.FirstOrDefault(s => s.Face == Faces.LEFT) == null)
                    continue;

                foreach (var sticker in piece.Stickers)
                {
                    if (sticker.Face == Faces.LEFT)
                        continue;

                    switch (sticker.Face)
                    {
                        case Faces.FRONT:
                            sticker.PlaceOn(clockwise ? Faces.DOWN : Faces.UP);
                            break;
                        case Faces.BACK:
                            sticker.PlaceOn(clockwise ? Faces.UP : Faces.DOWN);
                            break;
                        case Faces.UP:
                            sticker.PlaceOn(clockwise ? Faces.FRONT : Faces.BACK);
                            break;
                        case Faces.DOWN:
                            sticker.PlaceOn(clockwise ? Faces.BACK : Faces.FRONT);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }
            }
        }

        #endregion LEFT

        #region FRONT

        // F
        public void RotateFrontClockwise()
        {

        }

        // F'
        public void RotateFrontCounterClockwise()
        {

        }

        #endregion FRONT

        #region RIGHT

        // R
        public void RotateRightClockwise()
        {

        }

        // R'
        public void RotateRightCounterClockwise()
        {

        }

        #endregion RIGHT

        #region BACK

        // B
        public void RotateBackClockwise()
        {

        }

        // B'
        public void RotateBackCounterClockwise()
        {

        }

        #endregion BACK

        #region DOWN

        // D
        public void RotateDownClockwise()
        {

        }

        // D'
        public void RotateDownCounterClockwise()
        {

        }

        #endregion DOWN

        public override string ToString()
        {
            var str = string.Empty;

            str += string.Format("          | {0} {1} {2} | \r\n", 
                GetStickerColor(_pieces[0, 2, 2], Faces.UP), GetStickerColor(_pieces[1, 2, 2], Faces.UP), GetStickerColor(_pieces[2, 2, 2], Faces.UP));
            str += string.Format("          | {0} {1} {2} | \r\n", 
                GetStickerColor(_pieces[0, 1, 2], Faces.UP), GetStickerColor(_pieces[1, 1, 2], Faces.UP), GetStickerColor(_pieces[2, 1, 2], Faces.UP));
            str += string.Format("          | {0} {1} {2} | \r\n", 
                GetStickerColor(_pieces[0, 0, 2], Faces.UP), GetStickerColor(_pieces[1, 0, 2], Faces.UP), GetStickerColor(_pieces[2, 0, 2], Faces.UP));

            str += string.Format("{0} {1} {2} | {3} {4} {5} | {6} {7} {8} | {9} {10} {11} \r\n",
                GetStickerColor(_pieces[0, 2, 2], Faces.LEFT), GetStickerColor(_pieces[0, 1, 2], Faces.LEFT), GetStickerColor(_pieces[0, 0, 2], Faces.LEFT),
                GetStickerColor(_pieces[0, 0, 2], Faces.FRONT), GetStickerColor(_pieces[1, 0, 2], Faces.FRONT), GetStickerColor(_pieces[2, 0, 2], Faces.FRONT),
                GetStickerColor(_pieces[2, 0, 2], Faces.RIGHT), GetStickerColor(_pieces[2, 1, 2], Faces.RIGHT), GetStickerColor(_pieces[2, 2, 2], Faces.RIGHT),
                GetStickerColor(_pieces[2, 2, 2], Faces.BACK), GetStickerColor(_pieces[1, 2, 2], Faces.BACK), GetStickerColor(_pieces[0, 2, 2], Faces.BACK));
            str += string.Format("{0} {1} {2} | {3} {4} {5} | {6} {7} {8} | {9} {10} {11} \r\n",
                GetStickerColor(_pieces[0, 2, 1], Faces.LEFT), GetStickerColor(_pieces[0, 1, 1], Faces.LEFT), GetStickerColor(_pieces[0, 0, 1], Faces.LEFT),
                GetStickerColor(_pieces[0, 0, 1], Faces.FRONT), GetStickerColor(_pieces[1, 0, 1], Faces.FRONT), GetStickerColor(_pieces[2, 0, 1], Faces.FRONT),
                GetStickerColor(_pieces[2, 0, 1], Faces.RIGHT), GetStickerColor(_pieces[2, 1, 1], Faces.RIGHT), GetStickerColor(_pieces[2, 2, 1], Faces.RIGHT),
                GetStickerColor(_pieces[2, 2, 1], Faces.BACK), GetStickerColor(_pieces[1, 2, 1], Faces.BACK), GetStickerColor(_pieces[0, 2, 1], Faces.BACK));
            str += string.Format("{0} {1} {2} | {3} {4} {5} | {6} {7} {8} | {9} {10} {11} \r\n",
                GetStickerColor(_pieces[0, 2, 0], Faces.LEFT), GetStickerColor(_pieces[0, 1, 0], Faces.LEFT), GetStickerColor(_pieces[0, 0, 0], Faces.LEFT),
                GetStickerColor(_pieces[0, 0, 0], Faces.FRONT), GetStickerColor(_pieces[1, 0, 0], Faces.FRONT), GetStickerColor(_pieces[2, 0, 0], Faces.FRONT),
                GetStickerColor(_pieces[2, 0, 0], Faces.RIGHT), GetStickerColor(_pieces[2, 1, 0], Faces.RIGHT), GetStickerColor(_pieces[2, 2, 0], Faces.RIGHT),
                GetStickerColor(_pieces[2, 2, 0], Faces.BACK), GetStickerColor(_pieces[1, 2, 0], Faces.BACK), GetStickerColor(_pieces[0, 2, 0], Faces.BACK));

            str += string.Format("          | {0} {1} {2} | \r\n",
                GetStickerColor(_pieces[0, 2, 0], Faces.DOWN), GetStickerColor(_pieces[1, 2, 0], Faces.DOWN), GetStickerColor(_pieces[2, 2, 0], Faces.DOWN));
            str += string.Format("          | {0} {1} {2} | \r\n",
                GetStickerColor(_pieces[0, 1, 0], Faces.DOWN), GetStickerColor(_pieces[1, 1, 0], Faces.DOWN), GetStickerColor(_pieces[2, 1, 0], Faces.DOWN));
            str += string.Format("          | {0} {1} {2} | \r\n",
                GetStickerColor(_pieces[0, 0, 0], Faces.DOWN), GetStickerColor(_pieces[1, 0, 0], Faces.DOWN), GetStickerColor(_pieces[2, 0, 0], Faces.DOWN));

            return str;
        }

        private static char GetStickerColor(Piece piece, Faces face)
        {
            return piece.Stickers.First(s => s.Face == face).Color.ToString()[0];
        }
    }
}
