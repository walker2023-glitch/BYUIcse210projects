using System;
using System.Formats.Asn1;
using System.Numerics;

public class Jobs
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    public bool _internship;
    public double _wage;
    public string _scheduleType;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    public void DisplayAll()
    {
        if (_internship != true)
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear} {_scheduleType} {_wage}");
        }
        else
        {
            Console.WriteLine($"{_jobTitle} internship ({_company}) {_startYear}-{_endYear} {_scheduleType} {_wage}");
        }
    }

    public bool CurrentWorkThere(int _currentYear)
    {
        if (_currentYear <= _endYear && _currentYear >= _startYear)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double MoneyMade(int _currentYear)
    {
        double TotalMoney = (_currentYear - _startYear) * _wage;
        return TotalMoney;
    }
}

