using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public string color;

    public Fruit()
    {
        color = "orange";
        Debug.Log("1st fruit constructor called");
    }

    public Fruit(string newColor)
    {
        color = newColor;
        Debug.Log("2nd Fruit Contructor Called");
    }

    public void Chop()
    {
        Debug.Log("The " + color + " fruit has been chopped.");
    }

    public void SayHello()
    {
        Debug.Log("Hello, I am a fruit.");
    }
}
