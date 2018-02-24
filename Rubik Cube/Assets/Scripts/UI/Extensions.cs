using System;
using Assets.Scripts.Core.Model.Enums;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public static class Extensions
    {
        public static Color ToUnityColor(this Colors color)
        {
            switch (color)
            {
                case Colors.RED:
                    return Color.red;
                case Colors.ORANGE:
                    return new Color(1, 0.5f, 0f);
                case Colors.WHITE:
                    return Color.white;
                case Colors.YELLOW:
                    return Color.yellow;
                case Colors.GREEN:
                    return Color.green;
                case Colors.BLUE:
                    return Color.blue;
                default:
                    throw new ArgumentOutOfRangeException(nameof(color), color, null);
            }
        }
    }
}
