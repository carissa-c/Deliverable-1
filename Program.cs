
        Console.WriteLine("How many people are we making PB&J sandwiches for?");
        int people = int.Parse(Console.ReadLine());

        Console.WriteLine("You need:");

        float totalSlicesNeeded = (people * 2);
            Console.WriteLine(totalSlicesNeeded + " slices of bread");

        float total_tbs_peanut_butter = (people * 2);
            Console.WriteLine(total_tbs_peanut_butter + " tablespoons of peanut butter");

        float total_tsp_jelly = (people * 4);
            Console.WriteLine(total_tsp_jelly + " teaspoons of jelly");

        Console.WriteLine("which is....");

        double totalLoavesNeeded = System.Math.Round((double)(totalSlicesNeeded / 28));
            Console.WriteLine((totalLoavesNeeded) + " loaves of bread");

        double total_jars_peanut_butter = System.Math.Round((double)(total_tbs_peanut_butter / 32));
            Console.WriteLine((total_jars_peanut_butter) + " jars of peanut butter");

        double total_jars_jelly = System.Math.Round((double)(total_tsp_jelly / 48));
            Console.WriteLine((total_jars_jelly) + " jars of jelly");

        Console.WriteLine("Would you like to restart? Enter yes or y to continue, or enter any other key to exit.");
        dynamic response = Console.ReadLine();

        Console.WriteLine("Your response is: " + response);
        Console.WriteLine("Goodbye!");

        while (true)

            if (response = "yes")

                if (response = "y");

                else
                {
                    Console.WriteLine("Goodbye!");
                }
    


