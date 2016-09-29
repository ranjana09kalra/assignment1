using UnityEngine;
using System.Collections;

public class enemyController : MonoBehaviour {
    public float speed;

    private Vector2 enemyPosition;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.right * speed;
        enemyPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void reset()
    {
        this.transform.position = enemyPosition;
    }
}
