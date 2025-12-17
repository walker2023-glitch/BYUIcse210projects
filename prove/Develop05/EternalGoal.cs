class EternalGoal :CheckListGoals
{
   public EternalGoal(string name, string desc, int pts) :base(name, desc, pts, 0, 0)
    {
        
    }

    public override int RecordEvent()
    {
        _currentCount++;
        return _pointsPerEvent;
    }

    public override string GetDisplayString()
    {
        return $"[] {_name} {_description} Streak: {_currentCount} times";
        

        
    }

    public override string GetSaveData()
    {
        return $"EternalGoal:+=+{_name}+=+{_description}+=+{_pointsPerEvent}+=+{_bonusPoints}+=+{_currentCount}+=+{_targetCount}+=+{_isComplete}";
    }








}