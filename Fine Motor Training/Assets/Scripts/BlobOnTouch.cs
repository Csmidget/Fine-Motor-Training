using UnityEngine;
using System.Collections;

public class BlobOnTouch : MonoBehaviour {

	Transform m_transform;
	int touchID;
	// Use this for initialization
	void Start () {
		m_transform = gameObject.GetComponent<Transform> ();
	}

	void Update()
	{
		//Debug.Log (Input.touches.Length);

		if (Touched ()) {
			Vector3 fingerPos = Input.GetTouch(touchID).position;
			
			Vector3 objPos = Camera.main.ScreenToWorldPoint (fingerPos);
			objPos.z = 0;
			
			m_transform.position = objPos;
		}
	}

	bool Touched()
	{
		if (AnchorPoint.instance.thumbAnchored) {
			for(int i = 1; i < Input.touches.Length; i++)
			{
				Vector3 wpt = Camera.main.ScreenToWorldPoint (Input.GetTouch (i).position);

				Vector2 touchPos = new Vector2 (wpt.x, wpt.y);

				if (GetComponent<CircleCollider2D> () == Physics2D.OverlapPoint (touchPos)) {
					touchID = i;
					return true;			
				}
			}
		}
		return false;
	}
}
