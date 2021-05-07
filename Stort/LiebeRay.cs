using System;
using Raylib_cs;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace Stort
{
    public class LiebeRay
    {
        // static List<LiebeRay> rayStuff = new List<LiebeRay>();
        public int x {get; set;}
        public int y {get; set;}
        public int w {get; set;}
        public int h {get; set;}
        public string tag {get; set;}
        public bool header = false;
        public LiebeRay toUp {get; set;}
        public LiebeRay toDown {get; set;}
        public LiebeRay toRight {get; set;}
        public LiebeRay toLeft {get; set;}
        public List<LiebeRay> visable;
        public List<LiebeRay> whatTab;
        public Action action;

        // public LiebeRay(int x, int y, int w, int h, string tag, bool header = false)
        // {
        //     rayStuff.Add(this);
        //     this.x = x;
        //     this.y = y;
        //     this.w = w;
        //     this.h = h;
        //     this.tag = tag;
        //     this.header = header;
        // }
        public void DrawBox()
        {
            if(header == true)
            {
                Raylib.DrawRectangleGradientEx(new Rectangle(x, y, w, h), Color.DARKPURPLE, Color.VIOLET, Color.DARKPURPLE , Color.VIOLET);
                Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
                Raylib.DrawText(tag, x + 10, y + 10, 30, Color.YELLOW);
            }
            else
            {
                Raylib.DrawRectangleGradientEx(new Rectangle(x, y, w, h), Color.DARKBLUE, Color.BLUE, Color.DARKBLUE , Color.BLUE);
                Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
                Raylib.DrawText(tag, x + 15, y + 15, 30, Color.ORANGE);
            }
            
            
            {
                // smoll
                // Raylib.DrawRectangle(x, y, w, h, Color.SKYBLUE);
                // Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
                // Raylib.DrawText(tag, x + 15, y + 15, 30, Color.ORANGE);

                // bick
                // Raylib.DrawRectangle(x -10, y -10, w +20, h +20, Color.SKYBLUE);
                // Raylib.DrawRectangleLines(x -10, y -10, w +20, h +20, Color.BLACK);
                // Raylib.DrawText(tag, x, y, 50, Color.ORANGE);

                
            }
        }
        public void DrawTab()
        {
            Raylib.DrawRectangleGradientEx(new Rectangle(x, y, w, h), Color.PINK, Color.MAGENTA, Color.DARKPURPLE , Color.MAGENTA);
            Raylib.DrawRectangleLines(x, y, w, h, Color.BLACK);
            Raylib.DrawText(tag, x + 10, y + 10, 30, Color.YELLOW);
        }
        static public void currentBox(LiebeRay current)
        {
            if(current.header == true)
            {
                // Raylib.DrawRectangle(current.x, current.y, current.w, current.h, Color.DARKPURPLE);
                Raylib.DrawRectangleGradientEx(new Rectangle(current.x, current.y, current.w, current.h), Color.PINK, Color.MAGENTA, Color.DARKPURPLE , Color.MAGENTA);
                Raylib.DrawRectangleLines(current.x, current.y, current.w, current.h, Color.BLACK);
                Raylib.DrawText(current.tag, current.x + 10, current.y + 10, 30, Color.YELLOW);
                Raylib.DrawLineEx(new Vector2(current.x + 10, current.y + current.h - 10), new Vector2(current.x + current.w - 5, current.y + current.h - 10), 5, Color.YELLOW);
            }
            else
            {
                // Raylib.DrawRectangle(current.x -10, current.y -10, current.w +20, current.h +20, Color.DARKBLUE);
                Raylib.DrawRectangleGradientEx(new Rectangle(current.x -10, current.y -10, current.w +20, current.h +20), Color.SKYBLUE, Color.BLUE, Color.DARKBLUE , Color.BLUE);
                Raylib.DrawRectangleLines(current.x -10, current.y -10, current.w +20, current.h +20, Color.BLACK);
                Raylib.DrawText(current.tag, current.x, current.y, 45, Color.ORANGE);
            }
        }   
    }
}
