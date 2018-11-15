using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {

	Text timerText;
	GameObject canvasObj;
	Transform child;

	void Start()
	{
		canvasObj = GameObject.Find("Canvas");
		child = canvasObj.transform.Find("lblTime");
		timerText = child.GetComponent<Text>();
		StartCoroutine(TimerTick());
	}

	IEnumerator TimerTick()
	{
		GameVariables.currentTime = GameVariables.allowedTime;
		while ( GameVariables.currentTime > 0)
		{
			// wait 1 sec
			yield return new WaitForSeconds(1.0f);
			GameVariables.currentTime--;
			timerText.text = "Time : " + GameVariables.currentTime;
		}
		// Game over and restart
		SceneManager.LoadScene("Scene_TP1");
	}

}