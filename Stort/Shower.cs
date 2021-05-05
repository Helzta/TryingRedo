using System;
using Raylib_cs;
using System.Collections.Generic;

namespace Stort
{
    static public class Shower
    {
        static public void PrintHubMenu()
        {
            // bool gameDay = false;
            LiebeRay centralTab = new LiebeRay(20, 70, 216, 50, "Central", true);
            LiebeRay squadTab = new LiebeRay(256, 70, 216, 50, "Squad", true);
            LiebeRay transferTab = new LiebeRay(492, 70, 216, 50, "Transfer", true);
            LiebeRay officeTab = new LiebeRay(728, 70, 216, 50, "Office", true);
            LiebeRay myClubTab = new LiebeRay(964, 70, 216, 50, "My Club", true);

            LiebeRay simulate = new LiebeRay(20, 140, 540, 190, "Simulate Day");
            LiebeRay news = new LiebeRay(580, 140, 600, 340, "News");
            LiebeRay cHubs = new LiebeRay(20, 350, 260, 380, "Squad Hub");
            LiebeRay league = new LiebeRay(300, 350, 260, 380, "Table");
            LiebeRay cTraining = new LiebeRay(580, 500, 290, 230, "Training");
            LiebeRay cInbox = new LiebeRay(890, 500, 290, 230, "Inbox");

            LiebeRay lineUp = new LiebeRay(20, 140, 590, 590, "Rotational 7");
            LiebeRay training = new LiebeRay(630, 530, 550, 200, "Training");
            LiebeRay squadHub = new LiebeRay(630, 140, 265, 175, "Squad Hub");
            LiebeRay youthSquad = new LiebeRay(915, 140, 265, 175, "Academy");
            LiebeRay teamSheet = new LiebeRay(630, 335, 550, 175, "Team Rotation");

            LiebeRay serachPlayer = new LiebeRay(20, 140, 275, 285, "Search\n Players");
            LiebeRay transferHub = new LiebeRay(315, 140, 275, 285, "Transfer\n Hub");
            LiebeRay transferHistory = new LiebeRay(610, 140, 275, 285, "Transfer\n History");
            LiebeRay finances = new LiebeRay(905, 140, 275, 285, "Financial");
            LiebeRay scouts = new LiebeRay(905, 445, 275, 285, "Scout\n Network");
            LiebeRay recommended = new LiebeRay(20, 445, 865, 285, "Scouted Players");

            LiebeRay inbox = new LiebeRay(20, 140, 570, 285, "Inbox");
            LiebeRay vision = new LiebeRay(610, 140, 570, 285, "Vision and\n Expectations");
            LiebeRay contracts = new LiebeRay(20, 445, 550, 285, "Player \n Contracts");
            LiebeRay manageStaff = new LiebeRay(590, 445, 285, 285, "Staff");
            LiebeRay browseJobs = new LiebeRay(895, 445, 285, 285, "Browse \n Jobs");

            LiebeRay kits = new LiebeRay(20, 140, 570,285, "Game Kits");
            LiebeRay arrangeFriendlies = new LiebeRay(610, 140, 570, 285, "Arrange Friendly");
            LiebeRay trophies = new LiebeRay(20, 445, 320, 285, "Club History");
            LiebeRay otherLeagues = new LiebeRay(360, 445, 400, 285, "Other Leagues");
            LiebeRay top25 = new LiebeRay(780, 445, 400, 285, "All Statistics");
            
            centralTab.toUp = centralTab;
            centralTab.toRight = squadTab;
            centralTab.toDown = simulate;
            centralTab.toLeft = myClubTab;
            centralTab.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, league, cTraining, cInbox};
            centralTab.whatTab = new List<LiebeRay>(){centralTab,};

            squadTab.toUp = squadTab;
            squadTab.toRight = transferTab;
            squadTab.toDown = lineUp;
            squadTab.toLeft = centralTab;
            squadTab.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, youthSquad, squadHub, training, teamSheet};
            squadTab.whatTab = new List<LiebeRay>(){squadTab};

            transferTab.toUp = transferTab;
            transferTab.toRight = officeTab;
            transferTab.toDown = serachPlayer;
            transferTab.toLeft = squadTab;
            transferTab.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, transferHistory, transferHub, serachPlayer, scouts, recommended, finances};
            transferTab.whatTab = new List<LiebeRay>(){transferTab};

            officeTab.toUp = officeTab;
            officeTab.toRight = myClubTab;
            officeTab.toDown = inbox;
            officeTab.toLeft = transferTab;
            officeTab.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, vision, inbox, manageStaff, contracts, browseJobs};
            officeTab.whatTab = new List<LiebeRay>(){officeTab};

            myClubTab.toUp = myClubTab;
            myClubTab.toRight = centralTab;
            myClubTab.toDown = kits;
            myClubTab.toLeft = officeTab;
            myClubTab.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, trophies, otherLeagues, top25};
            myClubTab.whatTab = new List<LiebeRay>(){myClubTab};

            simulate.toUp = centralTab;
            simulate.toRight = news;
            simulate.toDown = cHubs;
            simulate.toLeft = arrangeFriendlies;
            simulate.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, news, cHubs, league, cTraining, cInbox};
            simulate.whatTab = new List<LiebeRay>(){centralTab};
            
            news.toUp = centralTab;
            news.toRight = lineUp;
            news.toDown = cTraining;
            news.toLeft = simulate;
            news.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, cHubs, league, cTraining, cInbox};
            news.whatTab = new List<LiebeRay>(){centralTab};

            cHubs.toUp = simulate;
            cHubs.toRight = league;
            cHubs.toDown = cHubs;
            cHubs.toLeft = top25;
            cHubs.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, league, cTraining, cInbox};
            cHubs.whatTab = new List<LiebeRay>(){centralTab};

            league.toUp = simulate;
            league.toRight = cTraining;
            league.toDown = league;
            league.toLeft = cHubs;
            league.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, cTraining, cInbox};
            league.whatTab = new List<LiebeRay>(){centralTab};
            
            cTraining.toUp = news;
            cTraining.toRight = cInbox;
            cTraining.toDown = cTraining;
            cTraining.toLeft = league;
            cTraining.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, league, cInbox};
            cTraining.whatTab = new List<LiebeRay>(){centralTab};

            cInbox.toUp = news;
            cInbox.toRight = lineUp;
            cInbox.toDown = cInbox;
            cInbox.toLeft = cTraining;
            cInbox.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, league, cTraining};
            cInbox.whatTab = new List<LiebeRay>(){centralTab};
            
            lineUp.toUp = squadTab;
            lineUp.toRight = squadHub;
            lineUp.toDown = lineUp;
            lineUp.toLeft = news;
            lineUp.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, squadHub, youthSquad, teamSheet, training};
            lineUp.whatTab = new List<LiebeRay>(){squadTab};

            squadHub.toUp = squadTab;
            squadHub.toRight = youthSquad;
            squadHub.toDown = teamSheet;
            squadHub.toLeft = lineUp;
            squadHub.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, youthSquad, teamSheet, training};
            squadHub.whatTab = new List<LiebeRay>(){squadTab};

            youthSquad.toUp = squadTab;
            youthSquad.toRight = serachPlayer;
            youthSquad.toDown = teamSheet;
            youthSquad.toLeft = squadHub;
            youthSquad.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, squadHub, teamSheet, training};
            youthSquad.whatTab = new List<LiebeRay>(){squadTab};

            teamSheet.toUp = squadHub;
            teamSheet.toRight = serachPlayer;
            teamSheet.toDown = training;
            teamSheet.toLeft = lineUp;
            teamSheet.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, squadHub, youthSquad, training};
            teamSheet.whatTab = new List<LiebeRay>(){squadTab};
            
            training.toUp = teamSheet;
            training.toRight = recommended;
            training.toDown = training;
            training.toLeft = lineUp;
            training.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, squadHub, youthSquad, teamSheet};
            training.whatTab = new List<LiebeRay>(){squadTab};

            serachPlayer.toUp = transferTab;
            serachPlayer.toRight = transferHub;
            serachPlayer.toDown = recommended;
            serachPlayer.toLeft = youthSquad;
            serachPlayer.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, transferHub, transferHistory, finances, recommended, scouts};
            serachPlayer.whatTab = new List<LiebeRay>(){transferTab};

            transferHub.toUp = transferTab;
            transferHub.toRight = transferHistory;
            transferHub.toDown = recommended;
            transferHub.toLeft = serachPlayer;
            transferHub.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, serachPlayer, transferHistory, finances, recommended, scouts};
            transferHub.whatTab = new List<LiebeRay>(){transferTab};

            transferHistory.toUp = transferTab;
            transferHistory.toRight = finances;
            transferHistory.toDown = recommended;
            transferHistory.toLeft = transferHub;
            transferHistory.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, serachPlayer, transferHub, finances, recommended, scouts};
            transferHistory.whatTab = new List<LiebeRay>(){transferTab};

            finances.toUp = transferTab; 
            finances.toRight = inbox;
            finances.toDown = scouts;
            finances.toLeft = transferHistory;
            finances.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, serachPlayer, transferHub, transferHistory, recommended, scouts};
            finances.whatTab = new List<LiebeRay>(){transferTab};

            recommended.toUp = serachPlayer;
            recommended.toRight = scouts;
            recommended.toDown = recommended;
            recommended.toLeft = training;
            recommended.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, serachPlayer, transferHub, transferHistory, finances, scouts};
            recommended.whatTab = new List<LiebeRay>(){transferTab};

            scouts.toUp = finances;
            scouts.toRight = contracts;
            scouts.toDown = scouts;
            scouts.toLeft = recommended;
            scouts.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, serachPlayer, transferHub, transferHistory, finances, recommended};
            scouts.whatTab = new List<LiebeRay>(){transferTab};

            inbox.toUp = officeTab;
            inbox.toRight = vision;
            inbox.toDown = contracts;
            inbox.toLeft = finances;
            inbox.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, vision, contracts, manageStaff, browseJobs};
            inbox.whatTab = new List<LiebeRay>(){officeTab};

            vision.toUp = officeTab;
            vision.toRight = kits;
            vision.toDown = manageStaff;
            vision.toLeft = inbox;
            vision.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, contracts, manageStaff, browseJobs};
            vision.whatTab = new List<LiebeRay>(){officeTab};

            contracts.toUp = inbox;
            contracts.toRight = manageStaff;
            contracts.toDown = contracts;
            contracts.toLeft = scouts;
            contracts.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, vision, manageStaff, browseJobs};
            contracts.whatTab = new List<LiebeRay>(){officeTab};

            manageStaff.toUp = vision;
            manageStaff.toRight = browseJobs;
            manageStaff.toDown = manageStaff;
            manageStaff.toLeft = contracts;
            manageStaff.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, vision, contracts, browseJobs};
            manageStaff.whatTab = new List<LiebeRay>(){officeTab};

            browseJobs.toUp = vision; 
            browseJobs.toRight = kits;
            browseJobs.toDown = browseJobs;
            browseJobs.toLeft = manageStaff;
            browseJobs.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, vision, contracts, manageStaff};
            browseJobs.whatTab = new List<LiebeRay>(){officeTab};

            kits.toUp = myClubTab;
            kits.toRight = arrangeFriendlies;
            kits.toDown = trophies;
            kits.toLeft = vision;
            kits.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, arrangeFriendlies, trophies, otherLeagues, top25};
            kits.whatTab = new List<LiebeRay>(){myClubTab};

            arrangeFriendlies.toUp = myClubTab;
            arrangeFriendlies.toRight = simulate;
            arrangeFriendlies.toDown = top25;
            arrangeFriendlies.toLeft = kits;
            arrangeFriendlies.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, trophies, otherLeagues, top25};
            arrangeFriendlies.whatTab = new List<LiebeRay>(){myClubTab};

            trophies.toUp = kits;
            trophies.toRight = otherLeagues;
            trophies.toDown = trophies;
            trophies.toLeft = browseJobs;
            trophies.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, otherLeagues, top25};
            trophies.whatTab = new List<LiebeRay>(){myClubTab};

            otherLeagues.toUp = kits;
            otherLeagues.toRight = top25;
            otherLeagues.toDown = otherLeagues;
            otherLeagues.toLeft = trophies;
            otherLeagues.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, trophies, top25};
            otherLeagues.whatTab = new List<LiebeRay>(){myClubTab};

            top25.toUp = arrangeFriendlies;
            top25.toRight = cHubs;
            top25.toDown = top25;
            top25.toLeft = otherLeagues;
            top25.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, trophies, otherLeagues};
            top25.whatTab = new List<LiebeRay>(){myClubTab};

            int nextDay = 0;
            LiebeRay current = simulate;

            current.action = () => {
                System.Console.WriteLine("hej");
            };

            

            current.action();
            
            Raylib.InitWindow(1200,750, "");
            Raylib.SetTargetFPS(60);
            while (!Raylib.WindowShouldClose())
            {
                DateTime dtStart = new DateTime(2020, 6, 1);
                DateTime dtCurrent = dtStart.AddDays(nextDay);
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
