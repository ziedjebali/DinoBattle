using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grower : MonoBehaviour {


    public float growFactor;
   
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        transform.localScale += new Vector3(1, 1, 0f) * Time.deltaTime * growFactor;

    }
}
