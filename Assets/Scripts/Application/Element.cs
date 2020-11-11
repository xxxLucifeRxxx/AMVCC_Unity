using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public MyApp App;
    void Awake()
    {
        App = FindObjectOfType<MyApp>();
    }
}
