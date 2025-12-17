using System;
using System.Formats.Asn1; // Note: These 'using' directives are not strictly needed 
using System.Numerics;     // for this simple class, but are kept here.

/// <summary>
/// Represents a single job entry in a resume, tracking employment details and calculating earnings.
/// </summary>
public class Jobs
{
    // -----------------------------------------------------------------
    // Member Variables (Fields) - Represents the state/data of the job
    // -----------------------------------------------------------------
    
    /// <summary>The name of the company.</summary>
    public string _company;
    
    /// <summary>The official title of the position held.</summary>
    public string _jobTitle;
    
    /// <summary>The calendar year the employment began.</summary>
    public int _startYear;
    
    /// <summary>The calendar year the employment ended.</summary>
    public int _endYear;
    
    /// <summary>Indicates whether the position was an internship (True) or a standard job (False).</summary>
    public bool _internship;
    
    /// <summary>The hourly wage for the position.</summary>
    public double _wage;
    
    /// <summary>The type of employment schedule (e.g., "Full-time" or "Part-time").</summary>
    public string _scheduleType;

    // -----------------------------------------------------------------
    // Behaviors (Methods) - Defines the actions/functionality of the job
    // -----------------------------------------------------------------

    /// <summary>
    /// Displays the basic job information in the standard format: Title (Company) StartYear-EndYear.
    /// </summary>
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }

    /// <summary>
    /// Displays all available job details, including schedule type and wage.
    /// Prefixes the title with "internship" if the position was an internship.
    /// </summary>
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

    /// <summary>
    /// Determines if the current job was held during a specified year.
    /// </summary>
    /// <param name="_currentYear">The year to check against the job's duration.</param>
    /// <returns>True if the job spanned the given year; otherwise, False.</returns>
    public bool CurrentWorkThere(int _currentYear)
    {
        // Checks if the current year falls between or on the start and end years.
        if (_currentYear <= _endYear && _currentYear >= _startYear)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Calculates an estimated total amount of money earned at the job up to a specified year.
    /// NOTE: This is a simplified calculation (Wage * Years Worked) and does not account for hours worked.
    /// </summary>
    /// <param name="_currentYear">The year up to which earnings should be calculated.</param>
    /// <returns>The total estimated money made.</returns>
    public double MoneyMade(int _currentYear)
    {
        // Calculation assumes total years worked up to the current year, multiplied by the hourly wage.
        // A more realistic calculation would involve hours per week/year.
        double TotalMoney = (_currentYear - _startYear) * _wage;
        return TotalMoney;
    }
}