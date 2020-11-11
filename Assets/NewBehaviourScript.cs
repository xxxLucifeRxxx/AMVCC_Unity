using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{

    public Text text;
    public Button button;
    public InputField inputField;
    public InputField inputField1;
	// Use this for initialization

    
	void Start ()
    {
        button.onClick.AddListener(ButtonClick);
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    void ButtonClick()
    {
        text.text = inputField.text+inputField1.text;
    }
}
