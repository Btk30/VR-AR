using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordGrab : MonoBehaviour {

	float distance = 10;
	GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance(this.transform.position, player.transform.position);
		if ( distance < 2 )
		{
			this.transform.parent = player.transform;
			this.transform.localPosition = new Vector3(0.15f, 1.0f, 0.8f);
			this.transform.localRotation = Quaternion.identity;
			this.transform.localRotation = Quaternion.Euler(110, 180, 90);
		}
	}
}
