using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

/*
Alex Ato 
9-25-2020
Project 2
Design a game, gameplay wise, to be identically based off the Tv Game Show Deal or No Deal. We get to choose our themes and design how it appears but overall it should be a remake of Deal or No Deal
*/



public class panelSettings : MonoBehaviour
{
    public GameObject titlePanel;
    public GameObject menuPanel;
    public GameObject optionsPanel;
    
    public bool howToPlayPanel = false;
    void Start()
    {
        
        titlePanel.SetActive(true);
        menuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goToOptions(){
        optionsPanel.SetActive(true);
        titlePanel.SetActive(false);
    }
    public void goToTitle(){
        titlePanel.SetActive(true);
        menuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        //gamePanel.SetActive(false);
        //endGamePanel.SetActive(false);
    }
    public void goToMenu(){
        titlePanel.SetActive(false);
        menuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        howToPlayPanel = true;
        //gamePanel.SetActive(false);
        //endGamePanel.SetActive(false);
    }
    public void goToGame(){
        titlePanel.SetActive(false);
        menuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        //gamePanel.SetActive(true);
        //endGamePanel.SetActive(false);
    }
    public void goToEndGame(){
        titlePanel.SetActive(false);
        menuPanel.SetActive(false);
        optionsPanel.SetActive(false);
        //gamePanel.SetActive(false);
        //endGamePanel.SetActive(true);
    }
    public void restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
