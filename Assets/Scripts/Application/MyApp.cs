using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyApp : MonoBehaviour {

    public AppModel Model;
    public AppView View;
    public AppController Controller;


    void Awake()
    {
        View = FindObjectOfType<AppView>();
        Model = FindObjectOfType<AppModel>();

    }
    // Use this for initialization
    void Start ()
    {
        Controller = FindObjectOfType<AppController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
