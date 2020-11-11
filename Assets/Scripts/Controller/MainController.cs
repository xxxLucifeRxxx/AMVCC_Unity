using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : Element
{

	void Start ()
    {
        App.View.Main.button.onClick.AddListener(ButtonClick);
	}

    void ButtonClick()
    {
        App.View.Main.text.text = App.View.Main.inputOne.text + App.View.Main.inputTwo.text;
        App.Controller.PersonFirst.Name = App.View.Main.inputOne.text;
        App.Controller.PersonFirst.LastName = App.View.Main.inputTwo.text;
    }
}
