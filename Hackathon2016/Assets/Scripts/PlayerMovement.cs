using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rb;
    public float speed;
	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Keyboard.isKeyDown(KeyCode.A))
        {
            rb.AddForce(new Vector2(-speed, 0));
        }
        if (Keyboard.isKeyDown(KeyCode.D))
        {
            rb.AddForce(new Vector2(speed, 0));
        }
        if (Keyboard.isKeyDown(KeyCode.S))
        {
            rb.AddForce(new Vector2(0, -speed));
        }
        if (Keyboard.isKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(0, speed));
        }
    }
}
