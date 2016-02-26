using UnityEngine;
using System.Collections;

public class SetCamera : MonoBehaviour {

	GameState m_gameState;
	Camera m_camera;

	void Awake(){
		//m_gameState = GameState.instance;
	}

	void Start () {
		m_camera = gameObject.GetComponent<Camera> ();
		GameState.instance.GetCurrentCamera (m_camera);
	}
}
