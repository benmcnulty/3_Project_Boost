using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    [SerializeField] float mainThrust = 100f;
    [SerializeField] float rcsThrust = 100f;    

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
        float thrustThisFrame = mainThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.Space))
        {
            rigidBody.AddRelativeForce(Vector3.up * thrustThisFrame);

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

        float rotationThisFrame = rcsThrust * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
        {
            
            transform.Rotate(Vector3.forward * rotationThisFrame);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationThisFrame);
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
