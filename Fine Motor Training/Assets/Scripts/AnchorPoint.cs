using UnityEngine;
using UnityEngine.Events;
using System.Collections;


public class AnchorPoint : MonoBehaviour {

	public bool thumbAnchored;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		thumbAnchored = CheckThumb ();
	}

	bool CheckThumb()
	{
		if (Input.touches.Length >= 1) {
			Vector3 wpt = Camera.main.ScreenToWorldPoint (Input.GetTouch (0).position);
			
			Vector2 touchPos = new Vector2 (wpt.x, wpt.y);
			
			if (GetComponent<BoxCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
				//Debug.Log("Touched");
				return true;
			}
		}
		return false;
	}

	public static AnchorPoint instance = null;

	void Awake()
	{
		
		if (instance != null)
		{
			Debug.LogError("Singleton AnchorPoint already found...");
			Destroy(gameObject);
		}
		else
		{
			instance = this;
		}
	}


void OnCollisionEnter2D(Collision2D coll) {
	if (coll.gameObject.tag == "Shape") {
		PlayManager.instance.blobs.Remove(coll.gameObject);
		Destroy(coll.gameObject);
		PlayManager.instance.blobCollected.Invoke();
	}	
}

}
