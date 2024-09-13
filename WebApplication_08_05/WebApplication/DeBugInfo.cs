using System;


[AttributeUsage
    (AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field | 
    AttributeTargets.Method| 
    AttributeTargets.Property ,
    AllowMultiple = true)]

public class DeBugInfo : System.Attribute
{
    private int bugNo;
    private string developer;
    private string lastReview;
    private string messege;

    public DeBugInfo (int id , string dev , string review)
    {
        this.bugNo = id;
        this.developer = dev;
        this.lastReview = review;


    }

    public int BugNo {
        get { return bugNo; }
    
    }

    public string Developer
    {
        get { return developer; }
    }

    public string LastReview
    {
        get { return lastReview; }
    }

    public string Message
    {
        get { return messege; }

        set { messege = value; }
    }






   
}