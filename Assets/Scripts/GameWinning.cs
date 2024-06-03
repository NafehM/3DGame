using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWinning : MonoBehaviour
{
    public AudioClip winSound;

    private AudioSource audioSource;  // Reference to the AudioSource component

    void Start()
    {
        // Get the AudioSource component at start and check if it exists
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            Debug.LogError("Missing AudioSource component on the GameObject.");
        }
        if (winSound == null)
        {
            Debug.LogError("Win sound AudioClip is not assigned.");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            // Check if audio source and clip are not null before playing the sound
            if (audioSource != null && winSound != null)
            {
                audioSource.PlayOneShot(winSound);
                Debug.Log("Hostage rescued, game won!");
                // Load the victory scene or display a win message
                // SceneManager.LoadScene("WinScene");
            }
            else
            {
                Debug.LogError("AudioSource or AudioClip is null.");
            }
        }
    }
}
