using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudio : MonoBehaviour
{
	
	private AudioSource audio;
	private AudioClip sound;

	
	void Start()
	{
		
		audio = gameObject.AddComponent<AudioSource>();

	}

	
	void OnCollisionEnter(Collision collision)
	{
	
		if (collision.gameObject.tag == "Cube" || collision.gameObject.tag == "ground")
		{
			
			audio.PlayOneShot(sound);
		}
	}
}
