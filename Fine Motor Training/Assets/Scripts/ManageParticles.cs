using UnityEngine;
using System.Collections;

public class ManageParticles : MonoBehaviour {
	public ParticleSystem Touchparticle;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		foreach (Touch touch in Input.touches) {
			if (touch.phase == TouchPhase.Began && Input.touches.Length >= 2)
			{
			Vector3 fingerPos = touch.position;
			
			Vector3 objPos = Camera.main.ScreenToWorldPoint (fingerPos);
				objPos.z = -5;
			Instantiate(Touchparticle,objPos,Quaternion.identity);
			}
		}
	}
}
