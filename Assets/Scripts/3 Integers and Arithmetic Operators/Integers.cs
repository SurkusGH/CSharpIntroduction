using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        /* INTEGERS AND ARITHMETIC OPERATORS */

        int first = 100;
        int second = 200;

        // Addotion
        int sum = first + second; // 300
        Debug.Log(sum);

        sum = first + 500 + second + 200;
        Debug.Log(sum);

        // Substraction
        int sub = first - second; // -100
        Debug.Log(sub);

        // Multiplication
        int mul = 4 * first; // 400
        Debug.Log(mul);

        // Division

        int div = second / first; // 2
        Debug.Log(div);
    }
}
