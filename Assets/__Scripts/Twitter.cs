using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Twitter: MonoBehaviour {


	public string twitterNameParameter = "Check out my score!";
	private const string TWITTER_ADDRESS = "http://twitter.com/intent/tweet";
	private const string TWITTER_LANGUAGE = "en";

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}
	public void pressed(){
		Application.OpenURL(TWITTER_ADDRESS+"?text="+WWW.EscapeURL(twitterNameParameter+"\n"+ScoreManager.HIGH_SCORE+"\n"));

	}
}