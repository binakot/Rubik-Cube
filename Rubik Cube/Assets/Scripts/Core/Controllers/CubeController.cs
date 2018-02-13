using System;
using Assets.Scripts.Core.Model;
using Assets.Scripts.Core.Model.Events;
using Assets.Scripts.UI;
using Assets.Scripts.UI.Events;

namespace Assets.Scripts.Core.Controllers
{
    [Serializable]
    public sealed class CubeController
    {
        private readonly Cube model;
        private readonly CubeView view;

        public CubeController(Cube model, CubeView view)
        {
            this.model = model;
            this.view = view;

            this.view.OnCubeSideDragged += HandleCubeSideDragged;
            this.model.OnCubeChanged += HandleCubeChanged;
            this.model.OnCubeSolved += HandleCubeSolved;
        }

        private void HandleCubeSideDragged(object sender, CubeSideDraggedEventArgs cubeSideDraggedEventArgs)
        {
            model.Rotate(cubeSideDraggedEventArgs.Face, cubeSideDraggedEventArgs.Clockwise);
        }

        private void HandleCubeChanged(object sender, CubeChangedEventArgs cubeChangedEventArgs)
        {
            view.Render(cubeChangedEventArgs.Pieces);
        }

        private void HandleCubeSolved(object sender, CubeSolvedEventArgs cubeChangedEventArgs)
        {
            view.ShowCubeSolvedText();
        }
    }
}
