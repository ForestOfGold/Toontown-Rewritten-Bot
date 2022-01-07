using System;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;

namespace ToonTown_Rewritten_Bot
{
    class DoodleTraining
    {
        public static int numberOfFeeds, numberOfScratches;
        private static string selectedTrick;
        private static bool infiniteTimeCheckBox, feedCheckBox, scratchCheckBox;
        public static void startTrainingDoodle(int feeds, int scratches, bool unlimitedCheckBox, string trick, bool feed, bool scratch)
        {
            numberOfFeeds = feeds;
            numberOfScratches = scratches;
            selectedTrick = trick;
            infiniteTimeCheckBox = unlimitedCheckBox;
            feedCheckBox = feed;
            scratchCheckBox = scratch;
            feedAndScratch();
        }

        public static void feedAndScratch()
        {
            if (!infiniteTimeCheckBox)//infinite checkbox is not checked
            {
                //code here is required so it doesn't get stuck in infinite loop below
                if (feedCheckBox)
                    numberOfScratches = 0;
                else if (scratchCheckBox)
                    numberOfFeeds = 0;

                while (numberOfFeeds > 0 || numberOfScratches > 0)
                {
                    if (numberOfFeeds > 0)//feed doodle
                    {
                        feedDoodle();
                        numberOfFeeds--;
                    }
                    if (numberOfScratches > 0)//scratch doodle
                    {
                        scratchDoodle();
                        numberOfScratches--; 
                    }
                    determineSelectedTrick();//perform trick
                }
            }
            else //infinite checkbox is checked, so loop until stopped
            {
                while (true)
                {
                    if (feedCheckBox && scratchCheckBox)//feed and scratch are checked
                    {
                        feedDoodle();
                        scratchDoodle();
                    }
                    else if (feedCheckBox)//feed is checked
                    {
                        feedDoodle();
                    }
                    else if (scratchCheckBox)//scratch is checked
                    {
                        scratchDoodle();
                    }
                    determineSelectedTrick();
                }
            }
        }

        public static void determineSelectedTrick()
        {
            switch (selectedTrick)
            {
                case "Jump (5 - 10 laff)":
                    callDoodle();
                    for(int i = 0; i < 20; i++)
                    {
                        openSpeedChat();
                        trainJump();
                        Thread.Sleep(1000);
                    }
                    break;
                case "Beg (6 - 12 laff)":
                    callDoodle();
                    for(int i = 0; i < 20; i++)
                    {
                        openSpeedChat();
                        trainBeg();
                        Thread.Sleep(1000);
                    }
                    break;
                case "Play Dead (7 - 14 laff)":
                    callDoodle();
                    for(int i = 0; i < 20; i++)
                    {
                        openSpeedChat();
                        trainPlayDead();
                        Thread.Sleep(1000);
                    }
                    break;
                case "Rollover (8 - 16 laff)":
                    callDoodle();
                    for(int i = 0; i < 20; i++)
                    {
                        openSpeedChat();
                        trainRollover();
                        Thread.Sleep(1000);
                    }
                    break;
                case "Backflip (9 - 18 laff)":
                    callDoodle();
                    for(int i = 0; i < 20; i++)
                    {
                        openSpeedChat();
                        trainBackflip();
                        Thread.Sleep(1000);
                    }
                    break;
                case "Dance (10 - 20 laff)":
                    callDoodle();
                    for(int i = 0; i < 20; i++)
                    {
                        openSpeedChat();
                        trainDance();
                        Thread.Sleep(1000);
                    }
                    break;
                case "Speak (11 - 22 laff)":
                    callDoodle();
                    for(int i = 0; i < 20; i++)
                    {
                        openSpeedChat();
                        trainSpeak();
                        Thread.Sleep(1000);
                    }
                    break;
                default:
                    MessageBox.Show("Error. Please select a trick to train.");
                    break;
            }
        }

        public static void openSpeedChat()
        {
            //Below is the location for the SpeedChat button location
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("20"))
            {
                getCoords("20");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
                Thread.Sleep(100);

                //Below is the location for pets tab
                //check if coordinates for the button is (0,0). True means they're not (0,0).
                if (BotFunctions.checkCoordinates("21"))
                {
                    getCoords("21");
                    BotFunctions.MoveCursor(x, y);
                    BotFunctions.DoMouseClick();
                    Thread.Sleep(100);

                    //Below is the location for tricks tab
                    //check if coordinates for the button is (0,0). True means they're not (0,0).
                    if (BotFunctions.checkCoordinates("22"))
                    {
                        getCoords("22");
                        BotFunctions.MoveCursor(x, y);
                        BotFunctions.DoMouseClick();
                        Thread.Sleep(100);
                    }
                    else
                    {
                        BotFunctions.updateCoordinates("22");
                        openSpeedChat();
                    }
                }
                else
                {
                    BotFunctions.updateCoordinates("21");
                    openSpeedChat();
                }
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("20");
                openSpeedChat();
            }
        }

        public static void trainJump()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("23"))
            {
                getCoords("23");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("23");
                trainJump();
            }
        }

        public static void trainBeg()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("24"))
            {
                getCoords("24");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("24");
                trainBeg();
            }
        }

        public static void trainPlayDead()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("25"))
            {
                getCoords("25");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("25");
                trainPlayDead();
            }
        }

        public static void trainRollover()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("26"))
            {
                getCoords("26");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("26");
                trainRollover();
            }
        }

        public static void trainBackflip()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("27"))
            {
                getCoords("27");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("27");
                trainBackflip();
            }
        }

        public static void trainDance()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("28"))
            {
                getCoords("28");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("28");
                trainDance();
            }
        }

        public static void trainSpeak()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("29"))
            {
                getCoords("29");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("29");
                trainSpeak();
            }
        }

        public static void feedDoodle()
        {
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("18"))
            {
                getCoords("18");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
                Thread.Sleep(11500);
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("18");
                feedDoodle();
            }
        }

        public static void scratchDoodle()
        {
            if (BotFunctions.checkCoordinates("19"))
            {
                getCoords("19");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
                Thread.Sleep(10000);
            }
            else
            {
                BotFunctions.updateCoordinates("19");
                scratchDoodle();
            }
        }

        public static void callDoodle()
        {
            //Below is the location for the SpeedChat button location
            //check if coordinates for the button is (0,0). True means they're not (0,0).
            if (BotFunctions.checkCoordinates("20"))
            {
                getCoords("20");
                BotFunctions.MoveCursor(x, y);
                BotFunctions.DoMouseClick();
                Thread.Sleep(100);

                //Below is the location for pets tab
                //check if coordinates for the button is (0,0). True means they're not (0,0).
                if (BotFunctions.checkCoordinates("21"))
                {
                    getCoords("21");
                    BotFunctions.MoveCursor(x, y);
                    BotFunctions.DoMouseClick();
                    Thread.Sleep(100);

                    //Below is the location for "Here Boy!" button
                    //check if coordinates for the button is (0,0). True means they're not (0,0).
                    if (BotFunctions.checkCoordinates("30"))
                    {
                        getCoords("30");
                        BotFunctions.MoveCursor(x, y);
                        BotFunctions.DoMouseClick();
                        Thread.Sleep(1000);
                    }
                    else//means it was (0,0) and needs updated
                    {
                        BotFunctions.updateCoordinates("30");
                        openSpeedChat();
                    }
                }
                else//means it was (0,0) and needs updated
                {
                    BotFunctions.updateCoordinates("21");
                    openSpeedChat();
                }
            }
            else//means it was (0,0) and needs updated
            {
                BotFunctions.updateCoordinates("20");
                openSpeedChat();
            }
        }

        private static int x, y;
        private static void getCoords(String item)
        {
            int[] coordinates = BotFunctions.getCoordinates(item);
            x = coordinates[0];
            y = coordinates[1];
        }
    }
}
