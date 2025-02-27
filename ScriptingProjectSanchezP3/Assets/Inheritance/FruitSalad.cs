using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("creating the fruit");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple");
        Apple myApple = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        Debug.Log("creating the fruit");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple");
        myApple = new Apple("green");

        myFruit.SayHello();
        myFruit.Chop();

        myApple.SayHello();
        myApple.Chop();
    }
}
