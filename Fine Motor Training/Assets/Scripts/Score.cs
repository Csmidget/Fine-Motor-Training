using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public int currentScore = 0;

	Text m_text;

	// Use this for initialization
	void Start () {
		m_text = this.GetComponent<Text> ();
		m_text.text = currentScore.ToString();
		PlayManager.instance.blobCollected.AddListener (IncrementScore);
	}
	

	void IncrementScore()
	{
		currentScore++;
		m_text.text = currentScore.ToString();
	}


	// Update is called once per frame
	void Update () {
	
	}
}
