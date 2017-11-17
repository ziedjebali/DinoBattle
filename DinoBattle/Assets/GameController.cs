using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public static string colorState;

    public string[] colorStates = { "Red", "Green", "Yellow", "Blue" };

	// Use this for initialization
	void Start () {

        colorState = colorStates[Random.Range(0, colorStates.Length -1)];


        InvokeRepeating("changeColor", 4.0f, 5f);
		
	}


    void changeColor()
    {

        if(Player.currentColorState == colorState)
        {
            Debug.Log("Good!");
        }
        else
        {
            Debug.Log("You Lose!");
        }

        colorState = colorStates[Random.Range(0, colorStates.Length - 1)];

    }

    // Update is called once per frame
    void Update () {
	}
}
