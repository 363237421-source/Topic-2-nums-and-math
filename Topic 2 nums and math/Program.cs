namespace Topic_2_nums_and_math
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("I will now count my chickens:");
            Console.WriteLine("Hens " + (10 +5 * 2));
            Console.WriteLine("Roosters " + (25 + 30 / 6)); //does math inside the brackets inside the brackets
            Console.WriteLine("six" + 6);
            Console.WriteLine("6 + 6");
            Console.WriteLine("6" + 6);
            Console.WriteLine(6 + 6);
            Console.WriteLine();

            Console.WriteLine("Now I will count the eggs:");
            Console.WriteLine(11.0 / 2);

            Console.WriteLine("Is it true that 3+2<5-7?");

            Console.WriteLine(3 + 2 < 5 - 7);

            Console.WriteLine("What is 3+2? " + (3 + 2));
            Console.WriteLine("What is 5 - 7? " + (5 - 7));

            Console.WriteLine("Oh, that's why it's " + (3 + 2 < 5 - 7));

            //(22.5).ToString("C");
            Console.WriteLine();
            Console.WriteLine("Calculate the amount of money you earned working 8 hours, earning $21/Hour");
            Console.WriteLine();
            Console.WriteLine(("If you earn $21 an hour, in 8 hours you will earn ") + (21 * 8).ToString("C"));

            Console.WriteLine("");

            Console.WriteLine("Now, calculate how much each egg costs if it cost $6 for 12 eggs.");
            Console.WriteLine("");
            Console.WriteLine("If it costs $6 for 12 eggs, it would cost " + (6.0/12).ToString("C") + (" to buy a single egg"));

            Console.WriteLine("");

            Console.WriteLine("Alright then, calculate what the tax (13%) would be on an item costing $79.00");
            Console.WriteLine("");
            Console.WriteLine("That would simply be " + (0.13 * 79.99 + 79.99).ToString("C"));
            
            //There are 12" in 1' and each inch is 2.54'
            Console.WriteLine("");
            Console.WriteLine("Finally, how many centimeters are in 5'6''");
            Console.WriteLine("");
            Console.WriteLine("...That would be " + Math.Round((5 * 12) / 2.54, 2) + ("cm")); //I don't know how to round
        }
    }
}
