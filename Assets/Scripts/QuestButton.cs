﻿using UnityEngine;
using System.Collections;

public class QuestButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClicked() {
		GameObject.Find("GameManager").GetComponent<GameManager>().SceneTransition(GameManager.Scene.Load);
	}
}
