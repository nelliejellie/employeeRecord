using System;

class Employee{
    private string _fullName;
    private int _staffId;
    private DateTime _date;
    public string _jobTitle;
    public string _department;

    public Employee(string fullName, int staffId, DateTime date, string jobTitle, string department)
    {
        _fullName = fullName;
        _staffId = staffId;
        _date = date;
        _jobTitle = jobTitle;
        _department = department;
    }

    public string FullName{get{return _fullName;}}
    public int StaffId{get{return _staffId;}}

    
    public DateTime Date{get{return _date;}}

    public void ClockIn()
    {
        System.Console.WriteLine("i just clocked in");
    }

    public void ClockOut()
    {
        System.Console.WriteLine("just clocked out");
    }

    public void Work()
    {
        System.Console.WriteLine("im working now");
    }


}