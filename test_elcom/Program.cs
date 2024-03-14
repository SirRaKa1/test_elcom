// See https://aka.ms/new-console-template for more information
using test_elcom;

Console.WriteLine("Hello! Write the name for your tamagotchi");
Tamagotchi tamagotchi = new Tamagotchi(Console.ReadLine());
string state = tamagotchi.Name + " is idle";

while (tamagotchi.Health > 0)
{
    Console.Clear();
    Console.WriteLine(tamagotchi.ToString(state));
    Console.WriteLine("1. Feed\n2. Play\n3. Sleep\n4. Heal");
    try{
        int s = Convert.ToInt32(Console.ReadLine());
        switch (s)
        {
            case 1: 
                tamagotchi.Feed();
                state = tamagotchi.Name + " has eated";
                break;
            case 2: 
                tamagotchi.Play();
                state = tamagotchi.Name + " played with you";
                break;
            case 3: 
                tamagotchi.Sleep();
                state = tamagotchi.Name + " has slept";
                break;
            case 4: 
                tamagotchi.Heal();
                state = tamagotchi.Name + " has healed";
                break;
            default:
                Console.Clear();
                Console.WriteLine("Use numbers from the above\nPress any key to continue"); 
                Console.ReadKey();
                break;
        }
        if (tamagotchi.Health < 3) state = state + "\n" + tamagotchi.Name + " is almost dead";
    }
    catch (Exception ex) {
        Console.Clear();
        Console.WriteLine("Use numbers from the above\nPress any key to continue");
        Console.ReadKey();
    }
}
Console.Clear();
Console.WriteLine(tamagotchi.Name + " is dead");
Console.ReadKey();

