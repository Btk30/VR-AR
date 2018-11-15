using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsBehaviour : MonoBehaviour {

	AudioSource aud;
	GameObject worldObject;
	// Use this for initialization
	void Start () {
		worldObject = GameObject.Find("World");
		aud = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter( Collider other )
	{
		worldObject.SendMessage("AddCoin");

		Renderer objRenderer;
		Collider objCollider;
		objRenderer = GetComponent<Renderer>();
		objCollider = GetComponent<Collider>();
		objRenderer.enabled=false;
		objCollider.enabled=false;

		if( aud )
		{
			aud.Play();
		}
	}
}