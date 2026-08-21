using System;
namespace StudentMgmtSystemApp;
public class Student
{
    #region Fields
    int rollNo;
    int phy;
    int maths;
    int chem;

    /// <summary>
    /// CLR PROPERTIES
    /// </summary>
    
    public int RollNo
    {
        set
        {
            rollNo = value;
        }
        get
        {
            return rollNo;
        }
    }


    /// <summary>
    /// AUTO IMPLICIT PROPERTY
    /// </summary>
    
    public string Name{get;set;}
    public string Address{get;set;}

    public int Phy
    {
        set
        {
            if(value>=0 && value <= 100)
            {
                phy = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
        get
        {
            return phy;
        }
    }
    public int Chem
    {
        set
        {
            if(value>=0 && value <= 100)
            {
                chem = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
        get
        {
            return chem;
        }
    }
    public int Maths
    {
        set
        {
            if(value>=0 && value <= 100)
            {
                maths = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
        get
        {
            return maths;
        }
    }


    public int Total{get;set;}
    public float Result{get;set;}
    #endregion
}

[Serializable]