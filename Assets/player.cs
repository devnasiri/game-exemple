using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class player : MonoBehaviour {
    float DirectionX;
    Rigidbody2D rb; 
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void Update () {
        DirectionX = CrossPlatformInputManager.GetAxis("Horizontal");
         rb.velocity = new Vector2 (DirectionX * 100 , 0);
    }

    public void jump()
    {
        rb.AddForce(new Vector2(2, 10 * Time.deltaTime), ForceMode2D.Impulse);
    }
}
