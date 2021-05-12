using System;
using Raylib_cs;
using System.IO;
using System.Collections.Generic;
using System.Numerics;

namespace Stort
{
    public class LiebeRay
    {
        static public List<LiebeRay> rayStuff = new List<LiebeRay>();
        public float x {get; set;}
        public float y {get; set;}
        public float w {get; set;}
        public float h {get; set;}
        public string tag {get; set;}
        public bool header = false;
        public LiebeRay toUp {get; set;}
        public LiebeRay toDown {get; set;}
        public LiebeRay toRight {get; set;}
        public LiebeRay toLeft {get; set;}
        public List<LiebeRay> visable;
        public List<LiebeRay> whatTab;
        public Action action;

        // public LiebeRay(float x, float y, float w, float h, string tag, bool header = false)
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
                Raylib.DrawRectangleLines((int)x, (int)y, (int)w, (int)h, Color.BLACK);
                Raylib.DrawText(tag, (int)x + 10, (int)y + 10, 30, Color.YELLOW);
            }
            else
            {
                Raylib.DrawRectangleGradientEx(new Rectangle(x, y, w, h), Color.DARKBLUE, Color.BLUE, Color.DARKBLUE , Color.BLUE);
                Raylib.DrawRectangleLines((int)x, (int)y, (int)w, (int)h, Color.BLACK);
                Raylib.DrawText(tag, (int)x + 15, (int)y + 15, 30, Color.ORANGE);
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
            Raylib.DrawRectangleLines((int)x, (int)y, (int)w, (int)h, Color.BLACK);
            Raylib.DrawText(tag, (int)x + 10, (int)y + 10, 30, Color.YELLOW);
        }
        static public void currentBox(LiebeRay current)
        {
            if(current.header == true)
            {
                // Raylib.DrawRectangle(current.x, current.y, current.w, current.h, Color.DARKPURPLE);
                Raylib.DrawRectangleGradientEx(new Rectangle(current.x, current.y, current.w, current.h), Color.PINK, Color.MAGENTA, Color.DARKPURPLE , Color.MAGENTA);
                Raylib.DrawRectangleLines((int)current.x, (int)current.y, (int)current.w, (int)current.h, Color.BLACK);
                Raylib.DrawText(current.tag, (int)current.x + 10, (int)current.y + 10, 30, Color.YELLOW);
                Raylib.DrawLineEx(new Vector2(current.x + 10, current.y + current.h - 10), new Vector2(current.x + current.w - 5, current.y + current.h - 10), 5, Color.YELLOW);
            }
            else
            {
                // Raylib.DrawRectangle(current.x -10, current.y -10, current.w +20, current.h +20, Color.DARKBLUE);
                Raylib.DrawRectangleGradientEx(new Rectangle(current.x -10, current.y -10, current.w +20, current.h +20), Color.SKYBLUE, Color.BLUE, Color.DARKBLUE , Color.BLUE);
                Raylib.DrawRectangleLines((int)current.x -10, (int)current.y -10, (int)current.w +20, (int)current.h +20, Color.BLACK);
                Raylib.DrawText(current.tag, (int)current.x, (int)current.y, 45, Color.ORANGE);
            }
        }
        // static public void rawr()
        // {
        //     rayStuff.Add(centralTab);
        //     rayStuff.Add(squadTab);
        //     rayStuff.Add(transferTab);
        //     rayStuff.Add(officeTab);
        //     rayStuff.Add(myClubTab);
        //     rayStuff.Add(simulate);
        //     rayStuff.Add(news);
        //     rayStuff.Add(cHubs);
        //     rayStuff.Add(league);
        //     rayStuff.Add(cTraining);
        //     rayStuff.Add(cInbox);
        //     rayStuff.Add(lineUp);
        //     rayStuff.Add(squadHub);
        //     rayStuff.Add(youthSquad);
        //     rayStuff.Add(teamSheet);
        //     rayStuff.Add(training);
        //     rayStuff.Add(searchPlayer);
        //     rayStuff.Add(transferHub);
        //     rayStuff.Add(transferHistory);
        //     rayStuff.Add(finances);
        //     rayStuff.Add(recommended);
        //     rayStuff.Add(scouts);
        //     rayStuff.Add(inbox);
        //     rayStuff.Add(vision);
        //     rayStuff.Add(contracts);
        //     rayStuff.Add(manageStaff);
        //     rayStuff.Add(browseJobs);
        //     rayStuff.Add(kits);
        //     rayStuff.Add(arrangeFriendlies);
        //     rayStuff.Add(trophies);
        //     rayStuff.Add(otherLeagues);
        //     rayStuff.Add(top25);
        // }
        static public void PrintHubMenu(TabButton centralTab, TabButton squadTab, TabButton transferTab, TabButton officeTab, TabButton myClubTab, SimulateButton simulate, LiebeRay news, LiebeRay cHubs, LiebeRay league, LiebeRay cTraining, LiebeRay cInbox, LiebeRay lineUp, LiebeRay squadHub, LiebeRay youthSquad, LiebeRay teamSheet, LiebeRay training, LiebeRay searchPlayer, LiebeRay transferHub, LiebeRay transferHistory, LiebeRay finances, LiebeRay recommended, LiebeRay scouts, LiebeRay inbox, LiebeRay vision, LiebeRay contracts, LiebeRay manageStaff, LiebeRay browseJobs, LiebeRay kits, LiebeRay arrangeFriendlies, LiebeRay trophies, LiebeRay otherLeagues, LiebeRay top25)
        {
            // LiebeRay centralTab = new LiebeRay(20, 70, 216, 50, "Central", true);
            centralTab.x = 20;
            centralTab.y = 70;
            centralTab.w = 216;
            centralTab.h = 50;
            centralTab.tag = "Central";
            centralTab.header = true;
            centralTab.toUp = centralTab;
            centralTab.toRight = squadTab;
            centralTab.toDown = simulate;
            centralTab.toLeft = myClubTab;
            centralTab.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, league, cTraining, cInbox};
            centralTab.whatTab = new List<LiebeRay>(){centralTab};
            centralTab.action = () =>
            {
                centralTab.DoABarrelRoll();
            };
            // LiebeRay squadTab = new LiebeRay(256, 70, 216, 50, "Squad", true);
            squadTab.x = 256;
            squadTab.y = 70;
            squadTab.w = 216;
            squadTab.h = 50;
            squadTab.tag = "Squad";
            squadTab.header = true;
            squadTab.toUp = squadTab;
            squadTab.toRight = transferTab;
            squadTab.toDown = lineUp;
            squadTab.toLeft = centralTab;
            squadTab.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, youthSquad, squadHub, training, teamSheet};
            squadTab.whatTab = new List<LiebeRay>(){squadTab};
            squadTab.action = () =>
            {
                squadTab.DoABarrelRoll();
            };
            // LiebeRay transferTab = new LiebeRay(492, 70, 216, 50, "Transfer", true);
            transferTab.x = 492;
            transferTab.y = 70;
            transferTab.w = 216;
            transferTab.h = 50;
            transferTab.tag = "Transfer";
            transferTab.header = true;
            transferTab.toUp = transferTab;
            transferTab.toRight = officeTab;
            transferTab.toDown = searchPlayer;
            transferTab.toLeft = squadTab;
            transferTab.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, transferHistory, transferHub, searchPlayer, scouts, recommended, finances};
            transferTab.whatTab = new List<LiebeRay>(){transferTab};
            transferTab.action = () =>
            {
                transferTab.DoABarrelRoll();
            };
            // LiebeRay officeTab = new LiebeRay(728, 70, 216, 50, "Office", true);
            officeTab.x = 728;
            officeTab.y = 70;
            officeTab.w = 216;
            officeTab.h = 50;
            officeTab.tag = "Office";
            officeTab.header = true;
            officeTab.toUp = officeTab;
            officeTab.toRight = myClubTab;
            officeTab.toDown = inbox;
            officeTab.toLeft = transferTab;
            officeTab.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, vision, inbox, manageStaff, contracts, browseJobs};
            officeTab.whatTab = new List<LiebeRay>(){officeTab};
            officeTab.action = () =>
            {
                officeTab.DoABarrelRoll();
            };
            // LiebeRay myClubTab = new LiebeRay(964, 70, 216, 50, "My Club", true);
            myClubTab.x = 964;
            myClubTab.y = 70;
            myClubTab.w = 216;
            myClubTab.h = 50;
            myClubTab.tag = "My Club";
            myClubTab.header = true;
            myClubTab.toUp = myClubTab;
            myClubTab.toRight = centralTab;
            myClubTab.toDown = kits;
            myClubTab.toLeft = officeTab;
            myClubTab.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, trophies, otherLeagues, top25};
            myClubTab.whatTab = new List<LiebeRay>(){myClubTab};
            myClubTab.action = () =>
            {
                myClubTab.DoABarrelRoll();
            };
            // LiebeRay simulate = new LiebeRay(20, 140, 540, 190, "Simulate");
            simulate.x = 20;
            simulate.y = 140;
            simulate.w = 540;
            simulate.h = 190;
            simulate.tag = "Simulate";
            simulate.toUp = centralTab;
            simulate.toRight = news;
            simulate.toDown = cHubs;
            simulate.toLeft = arrangeFriendlies;
            simulate.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, news, cHubs, league, cTraining, cInbox};
            simulate.whatTab = new List<LiebeRay>(){centralTab};
            simulate.nextDay = 0;
            simulate.action = ()  =>
            {
                simulate.CheckDate();
            };
            // LiebeRay news = new LiebeRay(580, 140, 600, 340, "News");
            news.x = 580;
            news.y = 140;
            news.w = 600;
            news.h = 340;
            news.tag = "News";
            news.toUp = centralTab;
            news.toRight = lineUp;
            news.toDown = cTraining;
            news.toLeft = simulate;
            news.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, cHubs, league, cTraining, cInbox};
            news.whatTab = new List<LiebeRay>(){centralTab};
            // LiebeRay cHubs = new LiebeRay(20, 350, 260, 380, "Squad Hub");
            cHubs.x = 20;
            cHubs.y = 350;
            cHubs.w = 260;
            cHubs.h = 380;
            cHubs.tag = "Squad Hub";
            cHubs.toUp = simulate;
            cHubs.toRight = league;
            cHubs.toDown = cHubs;
            cHubs.toLeft = top25;
            cHubs.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, league, cTraining, cInbox};
            cHubs.whatTab = new List<LiebeRay>(){centralTab};
            // LiebeRay league = new LiebeRay(300, 350, 260, 380, "Table");
            league.x = 300;
            league.y = 350;
            league.w = 260;
            league.h = 380;
            league.tag = "Table";
            league.toUp = simulate;
            league.toRight = cTraining;
            league.toDown = league;
            league.toLeft = cHubs;
            league.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, cTraining, cInbox};
            league.whatTab = new List<LiebeRay>(){centralTab};
            // LiebeRay cTraining = new LiebeRay(580, 500, 290, 230, "Training");
            cTraining.x = 580;
            cTraining.y = 500;
            cTraining.w = 290;
            cTraining.h = 230;
            cTraining.tag = "Training";
            cTraining.toUp = news;
            cTraining.toRight = cInbox;
            cTraining.toDown = cTraining;
            cTraining.toLeft = league;
            cTraining.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, league, cInbox};
            cTraining.whatTab = new List<LiebeRay>(){centralTab};
            // LiebeRay cInbox = new LiebeRay(890, 500, 290, 230, "Inbox");
            cInbox.x = 890;
            cInbox.y = 500;
            cInbox.w = 290;
            cInbox.h = 230;
            cInbox.tag = "Inbox";
            cInbox.toUp = news;
            cInbox.toRight = lineUp;
            cInbox.toDown = cInbox;
            cInbox.toLeft = cTraining;
            cInbox.visable = new List<LiebeRay>(){myClubTab, squadTab, transferTab, officeTab, simulate, news, cHubs, league, cTraining};
            cInbox.whatTab = new List<LiebeRay>(){centralTab};
            // LiebeRay lineUp = new LiebeRay(20, 140, 590, 590, "Rotational 7");
            lineUp.x = 20;
            lineUp.y = 140;
            lineUp.w = 590;
            lineUp.h = 590;
            lineUp.tag = "Rotational 7";
            lineUp.toUp = squadTab;
            lineUp.toRight = squadHub;
            lineUp.toDown = lineUp;
            lineUp.toLeft = news;
            lineUp.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, squadHub, youthSquad, teamSheet, training};
            lineUp.whatTab = new List<LiebeRay>(){squadTab};
            // LiebeRay training = new LiebeRay(630, 530, 550, 200, "Training");
            training.x = 630;
            training.y = 530;
            training.w = 550;
            training.h = 200;
            training.tag = "Training";
            training.toUp = teamSheet;
            training.toRight = recommended;
            training.toDown = training;
            training.toLeft = lineUp;
            training.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, squadHub, youthSquad, teamSheet};
            training.whatTab = new List<LiebeRay>(){squadTab};
            // LiebeRay squadHub = new LiebeRay(630, 140, 265, 175, "Squad Hub");
            squadHub.x = 630;
            squadHub.y = 140;
            squadHub.w = 265;
            squadHub.h = 175;
            squadHub.tag = "Squad Hub";
            squadHub.toUp = squadTab;
            squadHub.toRight = youthSquad;
            squadHub.toDown = teamSheet;
            squadHub.toLeft = lineUp;
            squadHub.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, youthSquad, teamSheet, training};
            squadHub.whatTab = new List<LiebeRay>(){squadTab};
            // LiebeRay youthSquad = new LiebeRay(915, 140, 265, 175, "Academy");
            youthSquad.x = 915;
            youthSquad.y = 140;
            youthSquad.w = 265;
            youthSquad.h = 175;
            youthSquad.tag = "Academy";
            youthSquad.toUp = squadTab;
            youthSquad.toRight = searchPlayer;
            youthSquad.toDown = teamSheet;
            youthSquad.toLeft = squadHub;
            youthSquad.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, squadHub, teamSheet, training};
            youthSquad.whatTab = new List<LiebeRay>(){squadTab};
            // LiebeRay teamSheet = new LiebeRay(630, 335, 550, 175, "Team Rotation");
            teamSheet.x = 630;
            teamSheet.y = 335;
            teamSheet.w = 550;
            teamSheet.h = 175;
            teamSheet.tag = "Team Rotation";
            teamSheet.toUp = squadHub;
            teamSheet.toRight = searchPlayer;
            teamSheet.toDown = training;
            teamSheet.toLeft = lineUp;
            teamSheet.visable = new List<LiebeRay>(){centralTab, transferTab, officeTab, myClubTab, lineUp, squadHub, youthSquad, training};
            teamSheet.whatTab = new List<LiebeRay>(){squadTab};
            // LiebeRay searchPlayer = new LiebeRay(20, 140, 275, 285, "Search\n Players");
            searchPlayer.x = 20;
            searchPlayer.y = 140;
            searchPlayer.w = 275;
            searchPlayer.h = 285;
            searchPlayer.tag = "Search\n Players";
            searchPlayer.toUp = transferTab;
            searchPlayer.toRight = transferHub;
            searchPlayer.toDown = recommended;
            searchPlayer.toLeft = youthSquad;
            searchPlayer.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, transferHub, transferHistory, finances, recommended, scouts};
            searchPlayer.whatTab = new List<LiebeRay>(){transferTab};
            // LiebeRay transferHub = new LiebeRay(315, 140, 275, 285, "Transfer\n Hub");
            transferHub.x = 315;
            transferHub.y = 140;
            transferHub.w = 275;
            transferHub.h = 285;
            transferHub.tag = "Transfer\n Hub";
            transferHub.toUp = transferTab;
            transferHub.toRight = transferHistory;
            transferHub.toDown = recommended;
            transferHub.toLeft = searchPlayer;
            transferHub.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, searchPlayer, transferHistory, finances, recommended, scouts};
            transferHub.whatTab = new List<LiebeRay>(){transferTab};
            // LiebeRay transferHistory = new LiebeRay(610, 140, 275, 285, "Transfer\n History");
            transferHistory.x = 610;
            transferHistory.y = 140;
            transferHistory.w = 275;
            transferHistory.h = 285;
            transferHistory.tag = "Transfer\n History";
            transferHistory.toUp = transferTab;
            transferHistory.toRight = finances;
            transferHistory.toDown = recommended;
            transferHistory.toLeft = transferHub;
            transferHistory.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, searchPlayer, transferHub, finances, recommended, scouts};
            transferHistory.whatTab = new List<LiebeRay>(){transferTab};
            // LiebeRay finances = new LiebeRay(905, 140, 275, 285, "Financial");
            finances.x = 905;
            finances.y = 140;
            finances.w = 275;
            finances.h = 285;
            finances.tag = "Financial";
            finances.toUp = transferTab; 
            finances.toRight = inbox;
            finances.toDown = scouts;
            finances.toLeft = transferHistory;
            finances.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, searchPlayer, transferHub, transferHistory, recommended, scouts};
            finances.whatTab = new List<LiebeRay>(){transferTab};
            // LiebeRay scouts = new LiebeRay(905, 445, 275, 285, "Scout\n Network");
            scouts.x = 905;
            scouts.y = 445;
            scouts.w = 275;
            scouts.h = 285;
            scouts.tag = "Scout\n Network";
            scouts.toUp = finances;
            scouts.toRight = contracts;
            scouts.toDown = scouts;
            scouts.toLeft = recommended;
            scouts.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, searchPlayer, transferHub, transferHistory, finances, recommended};
            scouts.whatTab = new List<LiebeRay>(){transferTab};
            // LiebeRay recommended = new LiebeRay(20, 445, 865, 285, "Scouted Players");
            recommended.x = 20;
            recommended.y = 445;
            recommended.w = 865;
            recommended.h = 285;
            recommended.tag = "Scouted Players";
            recommended.toUp = searchPlayer;
            recommended.toRight = scouts;
            recommended.toDown = recommended;
            recommended.toLeft = training;
            recommended.visable = new List<LiebeRay>(){squadTab, officeTab, centralTab, myClubTab, searchPlayer, transferHub, transferHistory, finances, scouts};
            recommended.whatTab = new List<LiebeRay>(){transferTab};
            // LiebeRay inbox = new LiebeRay(20, 140, 570, 285, "Inbox");
            inbox.x = 20;
            inbox.y = 140;
            inbox.w = 570;
            inbox.h = 285;
            inbox.tag = "Inbox";
            inbox.toUp = officeTab;
            inbox.toRight = vision;
            inbox.toDown = contracts;
            inbox.toLeft = finances;
            inbox.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, vision, contracts, manageStaff, browseJobs};
            inbox.whatTab = new List<LiebeRay>(){officeTab};
            // LiebeRay vision = new LiebeRay(610, 140, 570, 285, "Vision and\n Expectations");
            vision.x = 610;
            vision.y = 140;
            vision.w = 570;
            vision.h = 285;
            vision.tag = "Vision and\n Expectations";
            vision.toUp = officeTab;
            vision.toRight = kits;
            vision.toDown = manageStaff;
            vision.toLeft = inbox;
            vision.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, contracts, manageStaff, browseJobs};
            vision.whatTab = new List<LiebeRay>(){officeTab};
            // LiebeRay contracts = new LiebeRay(20, 445, 550, 285, "Player \n Contracts");
            contracts.x = 20;
            contracts.y = 445;
            contracts.w = 570;
            contracts.h = 285;
            contracts.tag = "Player \n Contracts";
            contracts.toUp = inbox;
            contracts.toRight = manageStaff;
            contracts.toDown = contracts;
            contracts.toLeft = scouts;
            contracts.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, vision, manageStaff, browseJobs};
            contracts.whatTab = new List<LiebeRay>(){officeTab};
            // LiebeRay manageStaff = new LiebeRay(590, 445, 285, 285, "Staff");
            manageStaff.x = 610;
            manageStaff.y = 445;
            manageStaff.w = 275;
            manageStaff.h = 285;
            manageStaff.tag = "Staff";
            manageStaff.toUp = vision;
            manageStaff.toRight = browseJobs;
            manageStaff.toDown = manageStaff;
            manageStaff.toLeft = contracts;
            manageStaff.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, vision, contracts, browseJobs};
            manageStaff.whatTab = new List<LiebeRay>(){officeTab};
            // LiebeRay browseJobs = new LiebeRay(895, 445, 285, 285, "Browse \n Jobs");
            browseJobs.x = 905;
            browseJobs.y = 445;
            browseJobs.w = 275;
            browseJobs.h = 285;
            browseJobs.tag = "Browse \n Jobs";
            browseJobs.toUp = vision; 
            browseJobs.toRight = kits;
            browseJobs.toDown = browseJobs;
            browseJobs.toLeft = manageStaff;
            browseJobs.visable = new List<LiebeRay>(){transferTab, myClubTab, centralTab, squadTab, inbox, vision, contracts, manageStaff};
            browseJobs.whatTab = new List<LiebeRay>(){officeTab};
            // LiebeRay kits = new LiebeRay(20, 140, 570, 285, "Game Kits");
            kits.x = 20;
            kits.y = 140;
            kits.w = 570;
            kits.h = 285;
            kits.tag = "Game Kits";
            kits.toUp = myClubTab;
            kits.toRight = arrangeFriendlies;
            kits.toDown = trophies;
            kits.toLeft = vision;
            kits.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, arrangeFriendlies, trophies, otherLeagues, top25};
            kits.whatTab = new List<LiebeRay>(){myClubTab};
            // LiebeRay arrangeFriendlies = new LiebeRay(610, 140, 570, 285, "Arrange Friendly");
            arrangeFriendlies.x = 610;
            arrangeFriendlies.y = 140;
            arrangeFriendlies.w = 570;
            arrangeFriendlies.h = 285;
            arrangeFriendlies.tag = "Arrange Friendly";
            arrangeFriendlies.toUp = myClubTab;
            arrangeFriendlies.toRight = simulate;
            arrangeFriendlies.toDown = otherLeagues;
            arrangeFriendlies.toLeft = kits;
            arrangeFriendlies.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, trophies, otherLeagues, top25};
            arrangeFriendlies.whatTab = new List<LiebeRay>(){myClubTab};
            // LiebeRay trophies = new LiebeRay(20, 445, 320, 285, "Club History");
            trophies.x = 20;
            trophies.y = 445;
            trophies.w = 430;
            trophies.h = 285;
            trophies.tag = "Club History";
            trophies.toUp = kits;
            trophies.toRight = otherLeagues;
            trophies.toDown = trophies;
            trophies.toLeft = browseJobs;
            trophies.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, otherLeagues, top25};
            trophies.whatTab = new List<LiebeRay>(){myClubTab};
            // LiebeRay otherLeagues = new LiebeRay(360, 445, 400, 285, "Other Leagues");
            otherLeagues.x = 470;
            otherLeagues.y = 445;
            otherLeagues.w = 260;
            otherLeagues.h = 285;
            otherLeagues.tag = "Other \n Leagues";
            otherLeagues.toUp = kits;
            otherLeagues.toRight = top25;
            otherLeagues.toDown = otherLeagues;
            otherLeagues.toLeft = trophies;
            otherLeagues.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, trophies, top25};
            otherLeagues.whatTab = new List<LiebeRay>(){myClubTab};
            // LiebeRay top25 = new LiebeRay(780, 445, 400, 285, "All Statistics");
            top25.x = 750;
            top25.y = 445;
            top25.w = 430;
            top25.h = 285;
            top25.tag = "All Statistics";
            top25.toUp = arrangeFriendlies;
            top25.toRight = cHubs;
            top25.toDown = top25;
            top25.toLeft = otherLeagues;
            top25.visable = new List<LiebeRay>(){officeTab, centralTab, squadTab, transferTab, kits, arrangeFriendlies, trophies, otherLeagues};
            top25.whatTab = new List<LiebeRay>(){myClubTab};
        }
    }
}
