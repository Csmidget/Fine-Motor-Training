using UnityEngine;
using System.Collections;

public class GameState : MonoBehaviour
{

	public static GameState instance = null;

	Camera m_camera;

	int colorindex;
	Color currentcol;
	Color[] backColors = new Color[7]
	{Color.white,
		new Color(0.9f,0.9f,0.8f),
		new Color(0.8f,0.9f,0.9f),
		new Color(0.9f,0.8f,0.9f),
		new Color(0.8f,0.8f,0.9f),
		new Color(0.9f,0.8f,0.8f),
		new Color(0.8f,0.9f,0.8f)
	};


	void Awake(){

		if (instance != null)
		{
			Debug.LogError ("Singleton GameState already found...");
			Destroy (gameObject);
		} 
		else 
		{	
			instance = this;
		}

		DontDestroyOnLoad (this);
	}

	void Start(){
		colorindex = 0;
		currentcol = backColors [0];
	}

	void Update () {

		for (int i = 0; i < backColors.Length; i++) {
			if ( currentcol == backColors[i])
			{
				colorindex = i + 1  == backColors.Length ? 0 : i + 1;
			}
		}

		Color nextcol = backColors [colorindex];
		currentcol = Color.Lerp(currentcol, nextcol, 0.020f);
		m_camera.backgroundColor = currentcol;
	}

	public void GetCurrentCamera(Camera m_Camera){
		m_camera = m_Camera;
	}

}
