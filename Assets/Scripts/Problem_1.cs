using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_1 : MonoBehaviour
{
    //Call your custom functions and print out the returns values of boxes 12,4 and 13.5f by 1.3f.
    //You should have 48 and 17.55 as your return print outs. 
    void Start()
    {
        perm(48, 17.55);
        perm(13.5f, 1.3f);
    }



    //Part 1: 
    //Create a function called Perimeter that takes in two parameters of int length and int width
    //Calculate the perimeter of the box and return the value as an int.
    double perm(int length, double width)
    {
        return length * 2 + width * 2;
    }

    //Part 2: 
    //Overload the function by creating a float version of the same function
    float perm(float length, float width) {
        return length * 2 + width * 2;
    }

}
