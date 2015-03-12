﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {
	public Text timeText = null;
	private float timer = 50f;
	void Update () {
		timer -= Time.deltaTime;
		this.timeText.text = "" + this.timer.ToString("0");
		if (timer <= 0f){
			Time.timeScale = 0.0f;
		}
	}
}
