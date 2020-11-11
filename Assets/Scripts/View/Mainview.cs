using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mainview : MonoBehaviour
{
    public InputField inputOne;
    public InputField inputTwo;
    public Button button;
    public Text text;

	void Awake ()
    {
        inputOne = Tools.FindGameObject("InputOne").GetComponent<InputField>();
        inputTwo = Tools.FindGameObject("InputTwo").GetComponent<InputField>();
        button = Tools.FindGameObject("ButtonSend").GetComponent<Button>();
        text = Tools.FindGameObject("TextView").GetComponent<Text>();
    }
}
