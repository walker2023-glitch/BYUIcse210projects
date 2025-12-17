using System.Drawing;

class CheckListGoals
{
    protected int _targetCount;
    protected int _bonusPoints;
    protected int _currentCount;
    protected int _pointsPerEvent;

    protected bool _isComplete; 
    protected readonly string _name;
    protected readonly string _description;

   public CheckListGoals(string name, string desc, int pts, int target, int bonus)
    {
        this._name = name;
        this._description = desc;
        this._pointsPerEvent = pts;
        this._targetCount = target;
        this._bonusPoints = bonus;
    } 

    public virtual int RecordEvent()
    {
        
        if(_isComplete)
        {
            return 0;
        }

        _currentCount++;
        
        
        if (_currentCount == _targetCount)
        {
            this._isComplete = true;
            return _pointsPerEvent + _bonusPoints;
        }
        else
        {
            return _pointsPerEvent;
            
        }
        
    }

    public virtual bool CheckCompletion()
    {
        
        return _isComplete;
    }

    public virtual string GetDisplayString()
    {
       string status;
        if (_isComplete)
        {
            status = "+=+";
        }
        else
        {
            status = $"[{(_currentCount * 100)/_targetCount}%]";
        }
        
        return $"{status} {_name} {_description} {_currentCount}/{_targetCount}";
    }

    public virtual string GetSaveData()
    {
        return $"ChecklistGoal:+=+{_name}+=+{_description}+=+{_pointsPerEvent}+=+{_bonusPoints}+=+{_currentCount}+=+{_targetCount}+=+{_isComplete}";
    }
}