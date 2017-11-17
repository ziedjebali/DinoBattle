using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 4f;



    public Rigidbody2D rb;

    private float movementX = 0f;

    private float movementY = 0f;

    public static string currentColorState;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();




    }

    /*IEnumerator Scale()
    {
        float timer = 0;

        while (true) // this could also be a condition indicating "alive or dead"
        {
            // we scale all axis, so they will have the same value, 
            // so we can work with a float instead of comparing vectors
            while (maxSize > transform.localScale.x)
            {
                timer += Time.deltaTime;
                transform.localScale += new Vector3(1,1,0f) * Time.deltaTime * growFactor;
                yield return null;
            }
            // reset the timer

            yield return new WaitForSeconds(waitTime);

            timer = 0;


        }
    }
    */

    // Update is called once per frame
    void Update () {



        movementX = Input.GetAxisRaw("Horizontal") * speed;
        movementY = Input.GetAxisRaw("Vertical") * speed;


        RaycastHit hit;

        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;

        Debug.DrawRay(transform.position, forward, Color.black);

        if(Physics.Raycast(transform.position,(forward), out hit))
        {
            if(hit.collider.tag == "Red")
            {
                currentColorState = "Red";
            }
            else if (hit.collider.tag == "Blue")
            {
                currentColorState = "Blue";
            }
            else if (hit.collider.tag == "Yellow")
            {
                currentColorState = "Yellow";
            }
            else if (hit.collider.tag == "Green")
            {
                currentColorState = "Green";
            }
        }

		
	}

    void FixedUpdate()
    {

        rb.MovePosition(rb.position + new Vector2(movementX * Time.fixedDeltaTime, movementY * Time.fixedDeltaTime));

    }

    /*void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Red")
        {
            colorState = "Red";
        }else if (col.tag == "Blue")
        {
            colorState = "Blue";

        }
        else if (col.tag == "Green")
        {
            colorState = "Green";

        }
        else if (col.tag == "Yellow")
        {
            colorState = "Yellow";

        }
        */

    }


