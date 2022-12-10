using UnityEngine;

namespace RimuruDev
{
    public enum ColorType { Violet, Red, Yellow, Magenta, Cyan }

    public static class Console
    {
        public static void Log(string message, ColorType colorType)
        {
            switch (colorType)
            {
                case ColorType.Violet: Debug.Log("-><color=#9400D3>" + $"{message}" + "</color>"); break;
                case ColorType.Red: Debug.Log("-><color=#FF4040>" + $"{message}" + "</color>"); break;
                case ColorType.Yellow: Debug.Log("-><color=#FFFF00>" + $"{message}" + "</color>"); break;
                case ColorType.Magenta: Debug.Log("-><color=#9400D3>" + $"{message}" + "</color>"); break;
                case ColorType.Cyan: Debug.Log("-><color=#00EEEE>" + $"{message}" + "</color>"); break;
                default:
                    Debug.Log($"default:{message}");
                    break;
            }
        }

        public static void Log(string message) => Log(message, ColorType.Red);

        public static void Log(string message, string colorHex) => Debug.Log($"-><color={colorHex}>" + $"{message}" + "</color>");
    }
}