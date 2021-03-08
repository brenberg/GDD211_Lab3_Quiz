using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChildScript : ParentScript
{
    public string Name;
    public int Calories;
    public static int StaticCalories;
    public int Karmas;
    public static int StaticKarmas;
    public bool Alive;
    public string Message;
    public static string StaticMessage;

    private void OnMouseDown()
    {
        StaticMessage = Message;
        StaticCalories = Calories;
        StaticKarmas = Karmas;
        UseItem();
    }


    public override void UseItem()
    {
        base.UseItem();
        Debug.Log("Put things here");
    }

}
