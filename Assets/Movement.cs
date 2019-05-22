using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Hello World!");
	}
	int lives=10;

	// Update is called once per frame
	void Update () {
		
		if (Input.GetKey (KeyCode.W))
			transform.Translate (Vector3.forward * 0.25f);
		if (Input.GetKey (KeyCode.S))
			transform.Translate (Vector3.back * 0.25f);
	
		if (Input.GetKey (KeyCode.A))
			transform.Translate (Vector3.left * 0.25f);
	
		if (Input.GetKey (KeyCode.D))
			transform.Translate (Vector3.right * 0.25f);
		if (Input.GetKeyDown (KeyCode.Space))
			transform.Translate (Vector3.up * 0.15f);

		Debug.Log (lives);
						
	}
	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "enemy") {	
			if (lives < 1)
				Application.LoadLevel (0);
			else
				lives = lives - 1;
		}
	}
}
