using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class World : MonoBehaviour {
	Text coinsText;
	GameObject canvasObj;
	Transform child;
	// Use this for initialization
	void Start () {
		canvasObj = GameObject.Find("Canvas");
		child = canvasObj.transform.Find("lblCoins");
		coinsText = child.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddCoins()
	{
		GameVariables.coins++;
		coinsText.text = "Coins: " + GameVariables.coins;
	}
}
