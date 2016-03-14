using UnityEngine;
using System.Collections;

public class CollisionTest : MonoBehaviour {
	Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate(){
		rb.MovePosition (rb.position + 0.1f * Vector2.right);
	}

	void OnCollisionEnter2D (Collision2D other){
		Debug.Log ("collisoion");
		transform.position = transform.position + 0.5f * Vector3.right;
	}

	void OnTriggerEnter2D (Collider2D other){
		Debug.Log ("Trigger");
	}
}
