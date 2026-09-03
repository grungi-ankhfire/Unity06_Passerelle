using System.Collections.Generic;

public class Greeter
{

    Dictionary<Moods, string> greetings = new()
    {
        {Moods.Happy, "Hey hey hey! Hellooooo friend!!"},
        {Moods.Angry, "'Sup. Get lost, I'm angry!"},
        {Moods.Sad, "Hi... *sigh* Welcome, I suppose..."}
    };
    string defaultGreeting = "Hello!";

    public string this[Moods mood]
    {
        get
        {
            if (greetings.ContainsKey(mood))
                return greetings[mood];
            return defaultGreeting;
        }
    }

}
