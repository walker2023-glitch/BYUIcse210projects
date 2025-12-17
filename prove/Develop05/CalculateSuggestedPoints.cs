//This one I asked AI for ideas on how to program and used some of it's advice, but made sure to write it and not copy and paste
public static class CalculateSuggestedPoints
{
    public static Dictionary<string, int> _tiers = new Dictionary<string, int>
    {
        {"Easy", 50},
        {"Medium", 300},
        {"Hard", 650},
        {"Legendary", 1000}
    };

    

    public static int GetSuggestion(string type, int difficulty)
    {
        int basePoints = 0;

        if(difficulty <= 3)
        {
            basePoints = _tiers["Easy"];
        }
    
        else if(difficulty <= 6)
        {
            basePoints = _tiers["Medium"];
        }
        else if(difficulty <= 10)
        {
            basePoints = _tiers["Hard"];
        }
        else if(difficulty == 11)
        {
            basePoints = _tiers["Legendary"];
        }
        
        return type switch
        {
            "ChecklistGoal" => (int)(basePoints * 2.5),
            "EternalGoal" => (int)(basePoints * 1.75),    
            _ => (int)(basePoints * 1.11)
        };
    }






}