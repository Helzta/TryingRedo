using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Stort
{
    public class TabButton: LiebeRay
    {
        public void DoABarrelRoll()
        {
            int isAllCorrect = 0;
            int state = 0;
            int frameCounter = 0;
            int windowX = Raylib.GetScreenWidth();
            bool anyTruers = true;
            while(anyTruers == true)
            {
                foreach (LiebeRay item in this.visable)
                {
                    // Doeet(item, anyTruers);
                    if(state == 0)
                    {
                        this.whatTab[0].x -= 50 / this.visable.Count;
                        item.x -= 50;
                        if(this.visable[this.visable.Count -1].x <= 0 - this.visable[this.visable.Count -1].w)
                        {
                            state = 1;
                        }
                    }
                    else if(state == 1)
                    {
                        frameCounter++;
                        if(frameCounter == 12 * this.visable.Count)
                        {
                            this.whatTab[0].x = windowX + this.whatTab[0].tryX;
                            for (int i = 0; i < this.visable.Count; i++)
                            {
                                this.visable[i].x = windowX + this.visable[i].tryX;
                                isAllCorrect++;
                            }
                            if(isAllCorrect == this.visable.Count)
                            {
                                isAllCorrect = 0;
                                state = 2;
                            }
                        }
                    }
                    else if(state == 2)
                    {
                        this.whatTab[0].x -= 50 / this.visable.Count;
                        item.x -= 50;
                        if(item.x <= item.tryX)
                        {
                            item.x = item.tryX;
                            isAllCorrect ++;
                        }
                        // for (int i = 0; i < this.visable.Count; i++)
                        // {
                        //     System.Console.WriteLine($"{this.visable[i].x} {this.visable[i].tryX}");
                        // }
                        if (isAllCorrect == this.visable.Count)
                        {
                            this.whatTab[0].x = tryX;
                            state = 3;
                        }
                    }
                    else if(state == 3)
                    {
                        anyTruers = false;
                    }
                }
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLUE);
                LiebeRay.currentBox(this.whatTab[0]);
                for (int i = 0; i < this.visable.ToArray().Length; i++)
                {
                    this.visable[i].DrawBox();
                }
                Raylib.EndDrawing();
            }
        }
        // public void Doeet(LiebeRay item, bool anyTruers)
        // {
        //     if(state == 0)
        //     {
        //         item.x -= 20;
        //         System.Console.WriteLine("bob");
        //         if(item.x <= 0 - item.w)
        //         {
        //             state = 1;
        //             System.Console.WriteLine(state);
        //         }
        //     }
        //     else if(state == 1)
        //     {
        //         System.Console.WriteLine("Bitch");
        //         frameCounter++;
        //         if(frameCounter == 20)
        //         {
        //             // this.whatTab[0].x = windowX + this.whatTab[0].tryX;
        //             item.x = windowX;
        //             state = 2;
        //         }
        //     }
        //     else if(state == 2)
        //     {
        //         // this.whatTab[0].x -= 50 / this.visable.Count;
        //         item.x -= 20;
        //         if(item.x <= item.tryX)
        //         {
        //             item.x = item.tryX;
        //             state = 3;
        //         }
        //         // for (int i = 0; i < this.visable.Count; i++)
        //         // {
        //         //     System.Console.WriteLine($"{this.visable[i].x} {this.visable[i].tryX}");
        //         // }
        //     }
        //     else if(state == 3)
        //     {
        //         anyTruers = false;
        //     }
        // }
    }
}