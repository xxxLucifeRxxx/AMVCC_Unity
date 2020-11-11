using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppController : Element
{
    public Person PersonFirst;
    public MainController Main;

    void Start()
    {
        PersonFirst = new Person();
        Main = gameObject.AddComponent<MainController>();
    }

    // Update is called once per frame
    void Update ()
    {
		
	}
}
