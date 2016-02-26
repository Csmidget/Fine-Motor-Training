using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Time : MonoBehaviour {

	public int currentTime = 10;
	
	Text m_text;
	
	// Use this for initialization
	void Start () {
		m_text = this.GetComponent<Text> ();
		m_text.text = currentTime.ToString();
		StartCoroutine(CountTime(1.0F));
	}


	IEnumerator CountTime(float waitTime) {
		yield return new WaitForSeconds(waitTime);
		currentTime--;
		m_text.text = currentTime.ToString();
		if( !(currentTime == 0))
		StartCoroutine(CountTime(1.0F));
	}

}
