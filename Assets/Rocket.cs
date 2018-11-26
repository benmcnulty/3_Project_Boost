using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody rigidBody;
    AudioSource audioSource;

    // Use this for initialization
    void Start () {
        rigidBody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        Thrust();
        Rotate();
    }

    private void Thrust()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up);
            if (!audioSource.isPlaying) // non-layering
            {
                audioSource.Play();
                FadeIn();
            }
            else
            {
                FadeIn();
            }
        }
        else
        {
            FadeOut();
        }
    }

    private void Rotate()
    {
        rigidBody.freezeRotation = true;

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * 30 * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * 30 * Time.deltaTime, Space.Self);
        }

        rigidBody.freezeRotation = false;
    }

    private void FadeIn()
    {
        if (audioSource.volume < 0.75f)
        {
            audioSource.volume += 1.0f * Time.deltaTime;
        }
    }

    private void FadeOut()
    {
        if (audioSource.volume > 0)
        {
            audioSource.volume -= 0.2f * Time.deltaTime;
        }
        else if (audioSource.volume <= 0)
        {
            audioSource.Stop();
        }
    }
}
