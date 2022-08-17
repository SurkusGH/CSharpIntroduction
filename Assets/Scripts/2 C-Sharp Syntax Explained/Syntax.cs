using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Syntax : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // This is a Comment
        // TODO: Add more stuff

        /*
         * 
         * This is
         * a         
         * Mutliline Comment
         * 
         */

        // Declaration
        int i;

        // Assignment
        i = 1;  

        // Output the String and the i variable
        // (Debug.Log is specific to Unity)
        Debug.Log("i: " + i);

        // Access variables/ and method of objects
        string s = "Hello World";
        Debug.Log("Lenght of String s: " + s.Length);
        s.Normalize();

        // Code Block with a new "scope"
        {
            // i can be accessed
            i = 2;

            // x is declared inside this scope
            int x = 0;
            Debug.Log(x);
        }

        // x cannot be accessed outside of the scope it was declared in
        // i = x + 1; // not possible
        // Debug.Log(x); // also not possible
    }
}
