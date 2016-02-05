using UnityEngine;
using System.Collections;

public class blobgrow : MonoBehaviour {

    SpriteRenderer m_SpriteRenderer;

	// Use this for initialization
	void Start () {

        m_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        int tempint;
        tempint = (int)Random.Range(-10.0F, 10.0F);

        m_SpriteRenderer.color = new Color(Random.Range(0f, 0.8f), Random.Range(0f, 0.8f), Random.Range(0f, 0.8f));
            
         //   = (int)Random.Range(-10.0F, 10.0F);
	}
	
	// Update is called once per frame
	void Update () {
        transform.localScale += new Vector3(0.001F, 0.001F, 0);
	}
}
