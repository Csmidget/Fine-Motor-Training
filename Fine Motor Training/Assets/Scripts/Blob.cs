using UnityEngine;
using System.Collections;

public class Blob : MonoBehaviour {
	
void OnCollisionEnter2D(Collision2D coll) {
	if (coll.gameObject.tag == "Anchor") {
			Destroy(gameObject);
		}

	}
}
