using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Stort
{
    class Program
    {
        static void Main(string[] args)
        {
            LiebeRay centralTab = new LiebeRay();
            LiebeRay squadTab = new LiebeRay();
            LiebeRay transferTab = new LiebeRay();
            LiebeRay officeTab = new LiebeRay();
            LiebeRay myClubTab = new LiebeRay();
            SimulateButton simulate = new SimulateButton();
            LiebeRay news = new LiebeRay();
            LiebeRay cHubs = new LiebeRay();
            LiebeRay league = new LiebeRay();
            LiebeRay cTraining = new LiebeRay();
            LiebeRay cInbox = new LiebeRay();
            LiebeRay lineUp = new LiebeRay();
            LiebeRay training = new LiebeRay();
            LiebeRay squadHub = new LiebeRay();
            LiebeRay youthSquad = new LiebeRay();
            LiebeRay teamSheet = new LiebeRay();
            LiebeRay searchPlayer = new LiebeRay();
            LiebeRay transferHub = new LiebeRay();
            LiebeRay transferHistory = new LiebeRay();
            LiebeRay finances = new LiebeRay();
            LiebeRay scouts = new LiebeRay();
            LiebeRay recommended = new LiebeRay();
            LiebeRay inbox = new LiebeRay();
            LiebeRay vision = new LiebeRay();
            LiebeRay contracts = new LiebeRay();
            LiebeRay manageStaff = new LiebeRay();
            LiebeRay browseJobs = new LiebeRay();
            LiebeRay kits = new LiebeRay();
            LiebeRay arrangeFriendlies = new LiebeRay();
            LiebeRay trophies = new LiebeRay();
            LiebeRay otherLeagues = new LiebeRay();
            LiebeRay top25 = new LiebeRay();
            Shower.PrintHubMenu(centralTab, squadTab, transferTab, officeTab, myClubTab, simulate, news, cHubs, league, cTraining, cInbox, lineUp, squadHub, youthSquad, teamSheet, training, searchPlayer, transferHub, transferHistory, finances, recommended, scouts, inbox, vision, contracts, manageStaff, browseJobs, kits, arrangeFriendlies, trophies, otherLeagues, top25);
            LiebeRay current = simulate;
            Raylib.InitWindow(1200,750, "");
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
            {
                DateTime dtStart = new DateTime(2020, 6, 1);
                DateTime dtCurrent = dtStart.AddDays(simulate.nextDay);
                string dtString = dtCurrent.ToString("dd MMMM yyyy");
                // (current, simulate, news, cHubs, league, cTraining, cInbox, lineUp, squadHub, youthSquad, training, teamSheet, serachPlayer, transferHub, transferHistory, finances, scouts, recommended, vision, inbox, contracts, manageStaff, browseJobs, kits, arrangeFriendlies, trophies, otherLeagues, top25);
                // (LiebeRay current, LiebeRay simulate, LiebeRay news, LiebeRay cHubs, LiebeRay league, LiebeRay cTraining, LiebeRay cInbox, LiebeRay lineUp, LiebeRay squadHub, LiebeRay youthSquad, LiebeRay training, LiebeRay teamSheet, LiebeRay serachPlayer, LiebeRay transferHub, LiebeRay transferHistory, LiebeRay finances, LiebeRay scouts, LiebeRay recommended, LiebeRay vision, LiebeRay inbox, LiebeRay contracts, LiebeRay manageStaff, LiebeRay browseJobs, LiebeRay kits, LiebeRay arrangeFriendlies, LiebeRay trophies, LiebeRay otherLeagues, LiebeRay top25)
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_W))
                {
                    current = current.toUp;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_A))
                {
                    current = current.toLeft;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_S))
                {
                    current = current.toDown;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_D))
                {
                    current = current.toRight;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_Q))
                {
                    current = current.visable[0];
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
                {
                    current = current.visable[1];
                }
                else if(Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                {
                    current.action();
                }
                foreach (LiebeRay LB in current.visable)
                {
                    LB.DrawBox();
                }
                foreach (LiebeRay wut in current.whatTab)
                {
                    wut.DrawTab();
                }
                LiebeRay.currentBox(current);

                if (current == simulate)
                {
                    Raylib.DrawText(dtString, simulate.x, simulate.y + 50, 30, Color.ORANGE);
                }
                else if(current.visable.Contains(simulate))
                {
                    Raylib.DrawText(dtString, simulate.x + 15, simulate.y + 45, 20, Color.ORANGE);
                }
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLUE);
                Raylib.EndDrawing();
            }
        }
    }
}
