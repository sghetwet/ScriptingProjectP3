using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeyApple : Fruitys
{

    public HeyApple()
    {
        Debug.Log("1st Apple Constuctor Called");
    }

    public override void Chop()
    {
        base.Chop();
        Debug.Log("the Apple has been chopped.");
    }

    public override void SayHello()
    {
        base.SayHello();
        Debug.Log("Hello, I am apple.");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
