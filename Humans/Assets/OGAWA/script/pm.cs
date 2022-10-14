using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pm : MonoBehaviour
{
    public static int value;
    public int startCount = 0;

    void OnMouseDown()
    {
        value += 1;
    }
}