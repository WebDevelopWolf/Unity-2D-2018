using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Set Max, Min and Guess Values
    int max;
    int min;
    int guess;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    // Game Introduction
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;

        Debug.Log(">> Welcome Stranger, to Number Hacker...");
        Debug.Log(">> You have been choosen...");
        Debug.Log(">> Before you ask any questions...");
        Debug.Log(">> We need to calibrate our systems to your thought processes...");
        Debug.Log(">> To do this we need you to think of an integer...");
        Debug.Log(">> Don't type it in the console though...they're watching us both...");
        Debug.Log(">> To calibrate correctly your integer needs to be between " + max + " & " + min);
        Debug.Log(">> If Integer > " + guess + "...press [Up] to re-calibrate X co-ords...");
        Debug.Log(">> If Integer < " + guess + "...press [Down] to re-calibrate Y co-ords...");
        Debug.Log(">> If Integer = " + guess + "...press [Enter] to save current configuration...");

        // Fix max bug
        max++;
    }

    // Update is called once per frame
    void Update()
    {
        // Check if Up Arrow is pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Calculate Guess
            Debug.Log(">> Checking X co-ordinates...");
            min = guess;
            CalculateGuess();
        }
        // Check if Down Arrow is pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Calculate Guess
            Debug.Log(">> Checking Y co-ordinates...");
            max = guess;
            CalculateGuess();
        }
        // Check if Enter or Return are pressed
        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            // Win Message
            Debug.Log(">> Systems calibrated...");
            Debug.Log(">> Augmented reality coming online...");
            Debug.Log(">> Stand by...");
            Debug.Log("********************************************************************");
            Debug.Log("********************************************************************");

            // Restart the game
            StartGame();
        }
    }

    void CalculateGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("*** " + guess + " ***");
    }
}
