using UnityEngine;
using System.Collections;

public class fishController : MonoBehaviour {

    //private instance variables
    private Transform _transform;
    public float speed;

	// Use this for initialization
	void Start () {
        //this._transform = this.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
       // this._move();
	}

    // this move method is goint to move the player object across y axis with the mouse
    void FixedUpdate()
    {
        float moveVerticle = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(0.0f,moveVerticle,0.0f);
        GetComponent<Rigidbody2D>().velocity = movement * speed;

        GetComponent<Rigidbody2D>().position = new Vector3(GetComponent<Rigidbody2D>().position.x, Mathf.Clamp(GetComponent<Rigidbody2D>().position.y, -125, 234), 0.0f);
        //this._transform.position = new Vector2(100f,Mathf.Clamp( Input.mousePosition.y, 234f,125f));
    }

    void OnCollision(Collision2D other)
    {
        
    }    //method to check boundary 

}
