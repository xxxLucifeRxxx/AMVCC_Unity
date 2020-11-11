using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppView : MonoBehaviour {

    public Mainview Main;
	// Use this for initialization
	void Awake ()
    {
        Main = gameObject.AddComponent<Mainview>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}   
