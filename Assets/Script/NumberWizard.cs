﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour
{
    // this will appear on Incpector of Unity
    //[SerializeField] int max;
    //[SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    [SerializeField] TextMeshProUGUI NumberOfGuessText;
    [SerializeField] Button higherButton;
    [SerializeField] Button lowerButton;


    int guess;
    int numberOfTry;
    int max = 100;
    int min = 1;

    void Start()
    {
        StartGame();
        

    }
    // start game method
    void StartGame()
    {
        NextGuess();
    }

    void NextGuess()
    {
        if (guess > 1 || guess < 100)
        {
            guess = Random.Range(min, max + 1);
            guessText.text = guess.ToString();
            numberOfTry = numberOfTry + 1;
            NumberOfGuessText.text = numberOfTry.ToString();
        } else
        {
            higherButton.interactable = false;
            lowerButton.interactable = false;
        }
    }

    // start form here

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

}
