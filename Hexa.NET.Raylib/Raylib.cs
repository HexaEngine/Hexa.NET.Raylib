﻿namespace Hexa.NET.Raylib
{
    using System.Runtime.InteropServices;

    public partial class Raylib
    {
        static Raylib()
        {
            InitApi();
        }

        public static readonly Color LightGray = new Color(200, 200, 200, 255);
        public static readonly Color Gray = new Color(130, 130, 130, 255);
        public static readonly Color DarkGray = new Color(80, 80, 80, 255);
        public static readonly Color Yellow = new Color(253, 249, 0, 255);
        public static readonly Color Gold = new Color(255, 203, 0, 255);
        public static readonly Color Orange = new Color(255, 161, 0, 255);
        public static readonly Color Pink = new Color(255, 109, 194, 255);
        public static readonly Color Red = new Color(230, 41, 55, 255);
        public static readonly Color Maroon = new Color(190, 33, 55, 255);
        public static readonly Color Green = new Color(0, 228, 48, 255);
        public static readonly Color Lime = new Color(0, 158, 47, 255);
        public static readonly Color DarkGreen = new Color(0, 117, 44, 255);
        public static readonly Color SkyBlue = new Color(102, 191, 255, 255);
        public static readonly Color Blue = new Color(0, 121, 241, 255);
        public static readonly Color DarkBlue = new Color(0, 82, 172, 255);
        public static readonly Color Purple = new Color(200, 122, 255, 255);
        public static readonly Color Violet = new Color(135, 60, 190, 255);
        public static readonly Color DarkPurple = new Color(112, 31, 126, 255);
        public static readonly Color Beige = new Color(211, 176, 131, 255);
        public static readonly Color Brown = new Color(127, 106, 79, 255);
        public static readonly Color DarkBrown = new Color(76, 63, 47, 255);
        public static readonly Color White = new Color(255, 255, 255, 255);
        public static readonly Color Black = new Color(0, 0, 0, 255);
        public static readonly Color Blank = new Color(0, 0, 0, 0); // Transparent
        public static readonly Color Magenta = new Color(255, 0, 255, 255);
        public static readonly Color RayWhite = new Color(245, 245, 245, 255);

        public static string GetLibraryName()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return "raylib";
            }
            return "libraylib";
        }
    }
}