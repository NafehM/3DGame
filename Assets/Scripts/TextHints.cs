using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextHints : MonoBehaviour
{

    float timer = 0.0f;
    Text textComponent;
    public Image backgroundImage; // Public variable to assign the background image in the editor

    // Use this for initialization
    void Start()
    {
        textComponent = GetComponent<Text>();
        if (textComponent == null)
        {
            Debug.LogError("Text component not found on the GameObject.");
            this.enabled = false;  // Disable the script if no Text component is found
        }
        if (backgroundImage == null)
        {
            Debug.LogError("Background Image not assigned.");
            this.enabled = false;  // Disable the script if no background image is assigned
        }
        else
        {
            backgroundImage.enabled = false; // Initially disable the background
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (textComponent.enabled)
        {
            timer += Time.deltaTime;
            if (timer >= 4)
            {
                textComponent.enabled = false;
                backgroundImage.enabled = false; // Hide the background when hiding the text
                timer = 0.0f;
            }
        }
    }

    void ShowHint(string message)
    {
        if (textComponent != null)
        {
            textComponent.text = message;
            textComponent.enabled = true;
            backgroundImage.enabled = true; // Show the background when showing the text
        }
    }
}