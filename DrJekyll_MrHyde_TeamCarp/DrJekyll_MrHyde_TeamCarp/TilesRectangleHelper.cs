// Created this class | Julius 18-11-21 
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DrJekyll_MrHyde_TeamCarp
{
    public static class TilesRectangleHelper
    {
        // Fyra olika bools som kollar en yttre rektangels kollision mot tile rektangelns fyra olika sidor | Julius 18-11-26
        public static bool TouchTopOf(this Rectangle r1, Rectangle r2)
        {
            return (
                    // Kollar rektangelns undersida mot Tilens översida minus en pixel (alltså kollar en pixel ovanför Tilen topp) | Julius 18-11-26
                    r1.Bottom >= r2.Top - 0 &&
                    // Kollar rektangelns undersida mot den övre fjärdedelen av Tilen | Julius 18-11-26
                    r1.Bottom <= r2.Top + (r2.Height / 4) &&
                    r1.Right >= r2.Left + (r2.Width / 4) &&
                    r1.Left <= r2.Right - (r2.Width / 4));
        }

        public static bool TouchBottomOf(this Rectangle r1, Rectangle r2)
        {
            return (r1.Top <= r2.Bottom + 0 &&
                    r1.Top >= r2.Bottom - (r2.Height / 4) &&
                    r1.Right >= r2.Left + (r2.Width / 4) &&
                    r1.Left <= r2.Right - (r2.Width / 4));
        }
        
        public static bool TouchLeftOf(this Rectangle r1, Rectangle r2)
        {
            return (r1.Right >= r2.Left - 0 &&
                    r1.Right <= r2.Right + (r2.Height / 4) &&
                    r1.Top <= r2.Bottom - (r2.Width / 4) &&
                    r1.Bottom >= r2.Top + (r2.Width / 4));
        }

        public static bool TouchRightOf(this Rectangle r1, Rectangle r2)
        {
            return (r1.Left <= r2.Right + 0 &&
                    r1.Left >= r2.Left + (r2.Height / 4) &&
                    r1.Top <= r2.Bottom - (r2.Width / 4) &&
                    r1.Bottom >= r2.Top + (r2.Width / 4));
        }
    }
}
