using System;
using Assets.Scripts.Core.Model;
using Assets.Scripts.UI;
using UnityEngine;

namespace Assets.Scripts.Core.Controllers
{
    [Serializable]
    public sealed class CubeController
    {
        private readonly Cube model;
        private readonly IView view;

        public CubeController(Cube model, IView view)
        {
            this.model = model;
            this.view = view;
            
            this.model.OnCubeChanged += (sender, args) => view.Render(args.Pieces);
            this.model.OnCubeSolved += (sender, args) => view.Solved();
            this.view.OnCubeSideDragged += (sender, args) => model.Rotate(args.Face, args.Clockwise);

#if UNITY_EDITOR
            this.model.OnCubeChanged += (sender, args) => Debug.Log(model.ToString());
#endif
        }

        public void ForceUpdate()
        {
            model.InvokeChangeEvent();
        }
    }
}
