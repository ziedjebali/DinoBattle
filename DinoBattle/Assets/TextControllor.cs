using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextControllor : MonoBehaviour {

    public Text colorText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        colorText.text = GameController.colorState.ToString();
	}
}
