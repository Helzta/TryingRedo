using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Stort
{
    public class TabButton: LiebeRay
    {
        float deltaTime = Raylib.GetFrameTime();
        int frameCounter = 0;
        float windowX = Raylib.GetScreenWidth();
        public void DoABarrelRoll()
        {
            int state = 0;
            List<LiebeRay> newVisable = new List<LiebeRay>(this.visable);
            foreach (LiebeRay sichOne in newVisable)
            {
                float newX = sichOne.x;
                if (state == 0)
                {
                    frameCounter++;
                    if (frameCounter == 120)
                    {
                        state = 1;
                    }
                }
                else if (state == 1)
                {
                    sichOne.x -= 0.1f;
                    if(sichOne.x <= 0)
                    {
                        state = 2;
                    }
                }
                else if (state == 2)
                {
                    frameCounter++;
                    if(frameCounter == 240)
                    {
                        sichOne.x = windowX;
                        state = 3;
                    }
                }
                else
                {
                    if (sichOne.x > newX)
                    {
                        sichOne.x -= 0.1f;
                    }
                }
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLUE);
                for (int i = 0; i < 4; i++)
                {
                    if(state == i)
                    {
                        if(sichOne.header == true)
                        {
                            Raylib.DrawRectangleGradientEx(new Rectangle(sichOne.x, y, w, h), Color.DARKPURPLE, Color.VIOLET, Color.DARKPURPLE , Color.VIOLET);
                            Raylib.DrawRectangleLines((int)sichOne.x, (int)y, (int)w, (int)h, Color.BLACK);
                            Raylib.DrawText(tag, (int)sichOne.x + 10, (int)y + 10, 30, Color.YELLOW);
                        }
                        else
                        {
                            Raylib.DrawRectangleGradientEx(new Rectangle(sichOne.x, y, w, h), Color.DARKBLUE, Color.BLUE, Color.DARKBLUE , Color.BLUE);
                            Raylib.DrawRectangleLines((int)sichOne.x, (int)y, (int)w, (int)h, Color.BLACK);
                            Raylib.DrawText(tag, (int)sichOne.x + 15, (int)y + 15, 30, Color.ORANGE);
                        }
                    }
                }
            }
        }
    }
}
