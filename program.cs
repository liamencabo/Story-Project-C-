String noun;
String adj;
String noun2;
String verb;

// Ask for a Noun
while (true)
{
    try
    {
        Console.Writeline("Please provide a noun: ");
        noun = Console.ReadLine();
        if(noun.Length > 0) { break; }
    }
    catch(Exception e) { Console.WriteLine("There was an error" + e); }
}
// Ask for Adjective
while(true)
{
    try
    {
        Console.Writeline("Please provide an adjective: ");
        adi = Console.ReadLine();
        if (adj.Length > 0) { break;}
    }
    catch (Exception e) { Console.WriteLine("There was an error" + e); }
}
// Ask for another Noun
while (true)
{
    try
    {
        Console.WrtieLine("Please provide another noun:");
        verb = Console.ReadLine();
        if (verb.length > 0) { break; }
    }
    catch (Exception e) { Console.WrtieLine("There was an error + e"); }
}
// Ask for Verb
while (true)
{
    try
    {
        Console.WriteLine("Please provide an verb: ");
        verb = Console.ReadLine();
        if (verb.length > 0) { break; }
    }
    catch (Exception e) { Console.WriteLine("There was an error" + e); }
}

String story = "All of a sound a " + noun + " rangm and the green boy said to Ryan, \"That is the signal. You must go into the Throne of Apocalypse.\"" + verb;

Console.WriteLine("Here is your final story...");
Console.WriteLine(story);