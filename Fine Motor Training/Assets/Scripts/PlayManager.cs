using UnityEngine;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class PlayManager : MonoBehaviour {

	public List<GameObject> blobPrefabs = new List<GameObject>();

	public List<GameObject> blobs;

	public UnityEvent ShapeHasSpawned = new UnityEvent();
	public UnityEvent ShapeHasDied = new UnityEvent ();
	public UnityEvent blobCollected = new UnityEvent();

	public void Addblob()
	{
		blobs.Add((GameObject)Instantiate(blobPrefabs[0]));
	}

	// Use this for initialization
	void Start () {
		blobs = new List<GameObject>();
		StartCoroutine(SpawnEnemy(2.0F));


	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public static PlayManager instance = null;
	
	void Awake()
	{
		
		if (instance != null)
		{
			Debug.LogError("Singleton PlayManager already found...");
			Destroy(gameObject);
		}
		else
		{
			instance = this;
		}
	}


IEnumerator SpawnEnemy(float waitTime) {
	yield return new WaitForSeconds(waitTime);
		if (blobs.Count < 5) Addblob ();
		StartCoroutine(SpawnEnemy(2.0F));
}

}