using System.Reflection;

class SimpleGoal :CheckListGoals
{
    public SimpleGoal(string name, string desc, int pts) :base(name, desc, pts, 1, 0)
    {
        
    }


    public override string GetDisplayString()
    {
        if(_isComplete){
        return $"[+=+] {_name} {_description}";
        }
        else
        {
            return $"[ ] {_name} {_description}";
        }
    }

    public override string GetSaveData()
    {
        return $"SimpleGoal:+=+{_name}+=+{_description}+=+{_pointsPerEvent}+=+{_bonusPoints}+=+{_currentCount}+=+{_targetCount}+=+{_isComplete}";
    }
}