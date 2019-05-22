using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("DIE!,Real life,you don't stand a chance!");
	}
	public GameObject target;	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target.transform);
			transform.Translate (Vector3.forward * 0.5f);
	
	}
}
