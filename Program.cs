using System;



namespace SpeletsSpel
{
    class Program
    {
        static void Main(string[] args)
        {
            Introduction();
            sceneOne();

        }
        public static void Introduction()
        {
            Console.WriteLine("Ett nytt virus har kommit till gbg och Henrik har förvandlats till ett monster");
            Console.WriteLine("Du hamnar mitt i kaoset");
            Console.WriteLine("Tryck på Enter för att börja Spelets spel™");
            Console.ReadLine();
            Console.Clear();
            sceneOne();

        }
        public static void sceneOne()
        {
            string choice;

            Console.WriteLine("Du möter Henrik i en mörk gränd");
            Console.WriteLine("Vad gör du?");
            Console.WriteLine("1. Ringer snuten");
            Console.WriteLine("2. Ringer Linn");
            Console.WriteLine("3. Skäms över min prestation i C# och springer därifrån");
            Console.Write("Ditt val: ");
            choice = Console.ReadLine();
            Console.Clear();

            switch (choice)
            {
                case "1":
                    {
                        Console.WriteLine("Du hör sirenerna komma närmare");
                        Console.WriteLine("Men Henrik är snabbare");
                        Console.WriteLine("Han äter upp dig");
                        Console.WriteLine("Du är död.");
                        Console.ReadLine();
                        gameOver();
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("Linn tar dig till en säker plats");
                        Console.WriteLine("Hon ger dig trygghet och glass, innan hon går ifrån dig");
                        Console.ReadLine();
                        sceneTwo();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Du springer hem till datorn");
                        Console.WriteLine("Du spenderar hela natten med att sitta framför tutorials");
                        Console.ReadLine();
                        sceneTwo();
                        break;
                    }
                default:
                    {

                        Console.WriteLine("Nej du den gick inte");
                        Console.WriteLine("Tryck Enter för att starta om spelet");
                        Console.ReadLine();
                        sceneOne();
                        break;
                    }
            }
        }
        public static void sceneTwo()
        {
            Random rnd = new Random();
            string[] sceneTwoOptions = { "Du hör steg närma sig, ska du springa? ja eller nej",
            "Du börjar bli sugen på pizza, beställer du en? ja eller nej",
            "Du hör Vincents röst från fjärran, ska du söka efter honom? ja eller nej"};
            int randomNumber = rnd.Next(0, 3);
            string sceneTwoText = sceneTwoOptions[randomNumber];
            

            string sceneTwoChoice;

            Console.WriteLine(sceneTwoText);
            Console.Write("Val: ");
            sceneTwoChoice = Console.ReadLine().ToLower();

            if (sceneTwoChoice == "ja")
            {
                Console.WriteLine("Du känner dig plötsligt iakttaget, nån tittar på dig");
                Console.ReadLine();
                Console.Clear();
                sceneThree();

            }
            else if (sceneTwoChoice == "nej")
            {
                Console.WriteLine("\nHelt plötsligt dyker Vincent upp, han gömmer något bakom ryggen");
                Console.WriteLine("Vincent ger dig en evig bensträckare, du står där tills du är 87 år");
                Console.WriteLine("och sen dör av bensträckning");
                Console.ReadLine();
                Console.Clear();
                gameOver();

            }
            else
            {
                Console.WriteLine("Du måste svara med Ja eller Nej");
                Console.WriteLine("Tryck på Enter för att fortsätta");
                Console.ReadLine();
                sceneTwo();
            }

        }


        public static void sceneThree()

        {
            int LifeDecision;
            Console.WriteLine("Du hör ett skrik långt borta, kanske någon i klassen behöver hjälp?");
            Console.WriteLine("Du känner dom ju inte så väl, men kanske värt ändå");
            Console.WriteLine("Slåss eller springa? 1 eller 2?");
            Console.Write("Val: ");
            int.TryParse(Console.ReadLine(), out LifeDecision);
            int LifeOrDeath = 0;
            bool dead = false;
            Console.Clear();
            while (LifeDecision != 1 && dead == false)
            {
                if (LifeOrDeath <= 0)
                {
                    Console.WriteLine("Du är för långsam, Henrik närmar sig");
                    Console.WriteLine("Vad väljer du? Slåss eller springa, 1 eller 2?");
                    Console.Write("Val: ");
                    int.TryParse(Console.ReadLine(), out LifeDecision);
                    LifeOrDeath++;
                }
                else if (LifeOrDeath >= 1)
                {
                    Console.WriteLine("Henrik hinner ifatt dig, du är livrädd och skakar.");
                    Console.WriteLine("Fortsätta springa eller spöa honom? 1 eller 2");
                    Console.Write("Val: ");
                    int.TryParse(Console.ReadLine(), out LifeDecision);
                    dead = true;
                }

            }
            if (dead == true)
            {
                Console.WriteLine("Henrik skjuter dig");
                Console.WriteLine("Allt svartnar");
                Console.ReadLine();
                gameOver();
            }
            else

            {
                Console.WriteLine("Henrik hoppar på och attackerar dig.");
                Console.WriteLine("Du slåss, sparkas och biter. Henrik blir skiträdd och springer därifrån");
                Console.ReadLine();
                youWin();
            }
        }

    

    public static void gameOver()
        {
            Console.Clear();
            Console.WriteLine("Du är död");
            Console.WriteLine("Men du hade ändå ett bra liv");
            Console.ReadLine();
            Console.Clear();
            Introduction();
        }

        public static void youWin()
        {
            Console.Clear();
            Console.WriteLine("Du lever!");
            Console.WriteLine("Linn förstod att du var i nöd och räddade dig");
            Console.WriteLine("Du är henne evigt tacksam");
            Console.ReadLine();
            Console.Clear();
            Introduction();
        }


    }
}