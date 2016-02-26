using UnityEngine;
using System.Collections;

public class blobgrow : MonoBehaviour {

	CircleCollider2D m_collider;

    SpriteRenderer m_SpriteRenderer;
	//Transform m_transform;
	float[,] Colors = new float[6,3] 	
	{	{1,0,0},
		{0,1,0},
		{0,0,1},
		{1,1,0},
		{1,0,1},
		{0,1,1},
		//{0.5f,0.5f,0},
		//{0,0.5f,0.5f},
		//{0.5f,0,0.5f}
	};

	// Use this for initialization
	void Start () {

		m_collider = gameObject.GetComponent<CircleCollider2D> ();

		//m_transform = gameObject.GetComponent<Transform> ();
        m_SpriteRenderer = gameObject.GetComponent<SpriteRenderer>();

        int tempint;
		tempint = (int)Random.Range (0,Colors.Length/3);
		gameObject.transform.position = new Vector3 (Random.Range (-8, 8), Random.Range (-1, 4), 0);
		//m_transform.position.Set(Random.Range (-8, 8),Random.Range (-4, 4),0);

		m_SpriteRenderer.color = new Color(Colors[tempint,0], Colors[tempint,1], Colors[tempint,2]);
            
         //   = (int)Random.Range(-10.0F, 10.0F);
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.localScale.x < 0.35)
        transform.localScale += new Vector3(0.001F, 0.001F, 0);
		m_collider.radius = transform.localScale.x* (4/transform.localScale.x);
	}
}
