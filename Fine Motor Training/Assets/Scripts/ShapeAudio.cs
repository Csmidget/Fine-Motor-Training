using UnityEngine;
using System.Collections;

public class ShapeAudio : MonoBehaviour {

    AudioSource m_audioSource;
    [SerializeField]
    AudioClip m_spawnSound;
    AudioClip m_deathSound;

	// Use this for initialization
	void Start () 
    {
        PlayManager.instance.ShapeHasSpawned.AddListener (SpawnSound);
        PlayManager.instance.ShapeHasDied.AddListener (DeathSound);

        m_audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () 
    {
	    
	}

    void Play(AudioClip _src)
    {
        m_audioSource.PlayOneShot(_src, 1.0f);
    }

    void SpawnSound()
    {
        Play(m_spawnSound);
    }

    void DeathSound()
    {
        Play(m_deathSound);
    }
}
