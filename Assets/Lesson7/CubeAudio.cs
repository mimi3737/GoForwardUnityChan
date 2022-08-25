using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAudio : MonoBehaviour
{
	private AudioSource audioSource;


	void Start()
	{
		audioSource = GetComponent<AudioSource>();

	}

	
	void OnCollisionEnter2D(Collision2D other)
	{
	
		
		{

			audioSource.Play();
		}
	}
}

