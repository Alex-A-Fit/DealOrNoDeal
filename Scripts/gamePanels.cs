using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

/*
Alex Ato 
9-25-2020
Project 2
Design a game, gameplay wise, to be identically based off the Tv Game Show Deal or No Deal. We get to choose our themes and design how it appears but overall it should be a remake of Deal or No Deal
*/



public class gamePanels : MonoBehaviour
{
    public GameObject gamePanel;
    public GameObject gameOptions;
    public GameObject banker;
    public GameObject deal;
    public GameObject moneyBackground;
    public GameObject gM;
    public GameObject ksPanel;
    public GameObject bankresponsePanel;
    public GameObject bankresponseText;
    int countChoices;
    public Text offer;
    public Text amountWon;

    private int bankOffer;
    private int bankOffer2;
    private int playersCaseAmt;
    private int playerOffer;
    public Text playerCO;
    public Text bankResponseNO;
    public Text bankResponseYES;
    public Text placeholderText;
    public int lastCaseNum;
    public double playersChoiceNum;
    public Text lastCaseTxt;

    public int counterOfferAvailable = 1;
    public int holdShittyC;
    public Button submitOffer;
    public InputField COtextOff;
    GameScript gameScript;

    //List<double> listRef = new List<double>();


    //GameScript moneyBox;
    //List<int> secretBox = new List<int>();



    void Start()
    {
        gamePanel.SetActive(true);
        gameOptions.SetActive(false);
        deal.SetActive(false);
        banker.SetActive(false);
        ksPanel.SetActive(false);
        bankresponsePanel.SetActive(false);
        //moneyBox.GetComponent<GameScript>();

        // listRef = gameScript.cashLeft;


    }

    // Update is called once per frame
    void Update()
    {
        gM = GameObject.Find("GAMEmanager");
        gameScript = gM.GetComponent<GameScript>();
        countChoices = gameScript.playerChoices;



    }
    public void optionsPage()
    {
        gamePanel.SetActive(false);
        gameOptions.SetActive(true);
        //endGamePanel.SetActive(false);
    }
    public void gamePage()
    {
        gamePanel.SetActive(true);
        gameOptions.SetActive(false);
        banker.SetActive(false);
        if (counterOfferAvailable == 0)
        {
            bankresponsePanel.SetActive(false);
            placeholderText.text = "No more counter offers";
            COtextOff.text = "No more counter offers";
        }

    }
    public void Deal()
    {
        gamePanel.SetActive(false);
        gameOptions.SetActive(false);
        deal.SetActive(true);
    }
    public void dealOrNoDeal()
    {
        if (countChoices == 6)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 60;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 11)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 35;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 15)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 30;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 18)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 8;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 20)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 6;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 21)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 5;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 22)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 4;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 23)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 3;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        else if (countChoices == 24)
        {
            banker.SetActive(true);
            moneyBackground.SetActive(true);
            gameScript.banksResponse();
            bankOffer = gameScript.cash;
            bankOffer = bankOffer / 2;
            offer.text = Convert.ToString(bankOffer);
            amountWon.text = offer.text;
            gamePanel.SetActive(false);
            gameOptions.SetActive(false);
            //endGamePanel.SetActive(false);
        }
        // else if (countChoices == 25)
        // {
        //     ksPanel.SetActive(true);

        // }

    }
    public void goToKSP()
    {
        if (countChoices == 25)
        {
            ksPanel.SetActive(true);
            lastCaseNum = Convert.ToInt32(gameScript.cashLeft[0]);
            Debug.Log(gameScript.playersCase2.text);
            Debug.Log(lastCaseNum);
            playersChoiceNum = Convert.ToInt32(gameScript.playersCase2.text);
            if(lastCaseNum == gameScript.cases[Convert.ToInt32(playersChoiceNum - 1)])
            {
                Debug.Log(lastCaseNum);
                Debug.Log("before Statement fired");
                lastCaseNum = Convert.ToInt32(gameScript.cashLeft[1]);
                Debug.Log("Statement fired");
                Debug.Log(lastCaseNum);
            }
            for (int c = 0; c < gameScript.cases.Count; c++)
            {
                if (lastCaseNum == gameScript.cases[c])
                {
                    holdShittyC = c + 1;
                    Debug.Log(holdShittyC);
                    lastCaseTxt.text = Convert.ToString(holdShittyC);
                    Debug.Log(lastCaseTxt.text);
                }
            }
        }
    }

    public void keep()
    {
        playersCaseAmt = Convert.ToInt32(gameScript.playersCaseValue);
        amountWon.text = Convert.ToString(playersCaseAmt);
    }
    public void switchcase()
    {
        for (int i = 0; i < gameScript.cashLeft.Count; i++)
        {
            if (gameScript.cashLeft[i] != gameScript.playersCaseValue)
            {
                amountWon.text = Convert.ToString(gameScript.cashLeft[i]);
            }
        }

    }
    public void counterOffer()
    {
        // bankoffer2 is a placeholder
        bankOffer2 = bankOffer + 40000;
        //converting input string to int for coomparison
        playerOffer = Convert.ToInt32(playerCO.text);
        //if player offer is too high, and they still have Counter-offer avail, it will run this code
        // if too high, decline player, else give them money
        if (playerOffer > bankOffer2 && counterOfferAvailable == 1)
        {
            bankresponsePanel.SetActive(true);
            bankResponseNO.text = "The Bank has declined your counter-offer!";
            counterOfferAvailable--;
            submitOffer.interactable = false;

        }
        else
        {
            bankResponseYES.text = "The Bank has accepted your offer!";
            amountWon.text = playerCO.text;
            deal.SetActive(true);
        }
    }
    public void BankResponsePanel()
    {
        if (counterOfferAvailable == 0)
        {
            bankresponseText.SetActive(false);
        }
    }

}
