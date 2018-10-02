using System;

namespace OpenHouseProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Basement basement = new Basement()
            {
                FloorSpace = 18,
                RoomName = "Basement"
            };
            Bathroom bathroom = new Bathroom()
            {
                FloorSpace = 18,
                RoomName = "Bathroom"
            };
            FrontPorch frontPorch = new FrontPorch()
            {
                FloorSpace = 18,
                RoomName = "Front Porch",
                Description = "flanked on both sides with Rose Bush " +
                "trussels"
            };
            GuestRoom guestRoom = new GuestRoom()
            {
                FloorSpace = 10,
                RoomName = "Guest Room",
                Furnishing = "a single size bed, and a small closet. It has " +
                "also just been recarpeted."
            };
            LivingRoom livingRoom = new LivingRoom()
            {
                FloorSpace = 16,
                RoomName = "Living Room"
            };
            MasterBedroom masterBedroom = new MasterBedroom()
            {
                FloorSpace = 14,
                RoomName = "Master Bedroom"
            };
            realtor realtor = new realtor("Nancy")
            {
                Employer = "Springwood Properties"
            };

            realtor.Speak($"Hi I'm {realtor.Name} from {realtor.Employer} " +
                $"Welcome to the open house.");
            Console.ReadLine();
            Console.Clear();
            realtor.Speak("Let me show you around.");

            realtor.Speak($"Of course, this is the {frontPorch.RoomName}. " +
                $"It is {frontPorch.Description}. ");
            realtor.Speak("Let's go inside so you can see the rest of the house.");
            Console.ReadLine();
            Console.Clear();
            realtor.Speak($"As you can see, you can step directly into the {livingRoom.RoomName}. " + "\n" +
               $"To our left is the {guestRoom.RoomName}. It is {guestRoom.FloorSpace} square feet. " + "\n" +
               $"It comes furnished with {guestRoom.Furnishing}");
            Console.ReadLine();
            Console.Clear();
            realtor.Speak($"If you want to, we can go upstairs and you can see the {masterBedroom.RoomName} or " +
                $"down the hall is the doorway to the {basement.RoomName}. " + "\n" + "Which would you like?");
            Console.ReadLine();
            Console.Clear();
            Console.Write($"To go upstairs just press the up arrow, to go down the hall and see the {basement.RoomName} " +
                $"press the down arrow.");

            if (Console.ReadKey(true).Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine(ConsoleKey.NumPad1.ToString());
                Console.ReadLine();
            }
            else if (Console.ReadKey(true).Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine(ConsoleKey.NumPad1.ToString());
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Sorry, I didn't understand that. Try again.");
                Console.ReadLine();
            }
        }
    }
}
