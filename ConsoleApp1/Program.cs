using ConsoleApp1;

void WelcomeMessage() 
{
Console.WriteLine("Hi, I'm Nat Hunt. Welcome to the Resource Manager!");
Console.WriteLine("Please choose from the following options:");
Console.WriteLine("Press 'r' for the list of resources available");
if (InputChecker(new string[] {"r"}))
    { 
    Console.WriteLine("");
    ResourceManagerPage();
    }
else
    {
        Console.WriteLine("Input not recognised...");
        WelcomeMessage();
    };
}


void ResourceManagerPage() 
{ 
Console.WriteLine($"You currently have {ResourceManager.ResourcesList.Count} Types of resources");

    if (ResourceManager.ResourcesList.Count > 0)
        {
        string x = string.Empty;

        foreach (var item in ResourceManager.ResourcesList)
            {
                x = item + ", ";
            }
            Console.WriteLine($"Your resources are: {x}");
        }

Console.WriteLine("Press 'w' to create Wood resource");
Console.WriteLine("Press 's' to create Stone resource");
Console.WriteLine("Press 'g' to create Gold resource");
}

bool InputChecker(string[] wanted_answers)
{
    string actual_answer = Console.ReadKey().Key.ToString().ToLower();
    foreach (var item in wanted_answers)
    {
        if (item == actual_answer)
        {
            return true;
        }
    }

    return false;
}


//Program
WelcomeMessage();


    

    
    








