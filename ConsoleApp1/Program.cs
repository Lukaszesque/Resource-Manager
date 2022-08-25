using ConsoleApp1;

Storage storage = new Storage();

string storeKey() => Console.ReadKey().Key.ToString().ToLower();


void WelcomeMessage() 
{
Console.WriteLine("Hi, I'm Nat Hunt. Welcome to the Resource Manager!");
Console.WriteLine("Please choose from the following options:");
Console.WriteLine("Press 'r' for the list of resources available");
if (InputChecker(new string[] {"r"}) == "r")
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
Console.WriteLine($"You currently have {storage.ResourcesList.Count} Types of resources");

    if (storage.ResourcesList.Count > 0)
        {
        string x = string.Empty;

        foreach (var item in storage.ResourcesList)
            {
                x = item.ResourceName + ", ";
            }
            Console.WriteLine($"Your resources are: {x}");
        }
    
Console.WriteLine("Press 'w' to create Wood resource");
Console.WriteLine("Press 's' to create Stone resource");
Console.WriteLine("Press 'g' to create Gold resource");

ResourceManager newResource;

string key = storeKey();

    switch (key) 
        { 
            case "w":
            newResource = new ResourceManager("Wood");
            storage.ResourcesList.Add(newResource);
            ResourceManagerPage();
            break;

            case "s":
            Console.WriteLine("Not yet implemented :D");
            ResourceManagerPage();
            break;

            case "g":
            Console.WriteLine("Not yet implemented :D");
            ResourceManagerPage();
            break;

    }
    



}

string InputChecker(string[] wanted_answers)
{
    string actual_answer = Console.ReadKey().Key.ToString().ToLower();
    foreach (var item in wanted_answers)
    {
        if (item == actual_answer)
        {
            return item;
        }
    }

    return "Incorrect input detected";
}


//Program
WelcomeMessage();


    

    
    








