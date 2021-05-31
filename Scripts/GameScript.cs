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



public class GameScript : MonoBehaviour
{
    public GameObject PanelL1;
    public Text panelL1;
    public GameObject PanelL2;
    public Text panelL2;
    public GameObject PanelL3;
    public Text panelL3;
    public GameObject PanelL4;
    public Text panelL4;
    public GameObject PanelL5;
    public Text panelL5;
    public GameObject PanelL6;
    public Text panelL6;
    public GameObject PanelL7;
    public Text panelL7;
    public GameObject PanelL8;
    public Text panelL8;
    public GameObject PanelL9;
    public Text panelL9;
    public GameObject PanelL10;
    public Text panelL10;
    public GameObject PanelL11;
    public Text panelL11;
    public GameObject PanelL12;
    public Text panelL12;
    public GameObject PanelL13;
    public Text panelL13;
    public GameObject PanelR1;
    public Text panelR1;
    public GameObject PanelR2;
    public Text panelR2;
    public GameObject PanelR3;
    public Text panelR3;
    public GameObject PanelR4;
    public Text panelR4;
    public GameObject PanelR5;
    public Text panelR5;
    public GameObject PanelR6;
    public Text panelR6;
    public GameObject PanelR7;
    public Text panelR7;
    public GameObject PanelR8;
    public Text panelR8;
    public GameObject PanelR9;
    public Text panelR9;
    public GameObject PanelR10;
    public Text panelR10;
    public GameObject PanelR11;
    public Text panelR11;
    public GameObject PanelR12;
    public Text panelR12;
    public GameObject PanelR13;
    public Text panelR13;

    public Text case1T, case2T, case3T, case4T, case5T, case6T, case7T, case8T, case9T, case10T, case11T, case12T, case13T, case14T, case15T, case16T, case17T, case18T, case19T, case20T, case21T, case22T, case23T, case24T, case25T, case26T;
    public Button case1, case2, case3, case4, case5, case6, case7, case8, case9, case10, case11, case12, case13, case14, case15, case16, case17, case18, case19, case20, case21, case22, case23, case24, case25, case26;

    public int caseNum = 0;
    public Text playersCase;
    public Text playersCase2;
    public Text casesRemaining;
    public List<double> cases = new List<double>();
    public List<double> caseValue = new List<double>();
    public List<double> cashLeft = new List<double>();
    public int playerChoices;
    public double playersCaseValue;
    double remains = 0;
    public int cash;

    // Start is called before the first frame update
    void Start()
    {

        PanelL1.SetActive(false);
        PanelL2.SetActive(false);
        PanelL3.SetActive(false);
        PanelL4.SetActive(false);
        PanelL5.SetActive(false);
        PanelL6.SetActive(false);
        PanelL7.SetActive(false);
        PanelL8.SetActive(false);
        PanelL9.SetActive(false);
        PanelL10.SetActive(false);
        PanelL11.SetActive(false);
        PanelL12.SetActive(false);
        PanelL13.SetActive(false);
        PanelR1.SetActive(false);
        PanelR2.SetActive(false);
        PanelR3.SetActive(false);
        PanelR4.SetActive(false);
        PanelR5.SetActive(false);
        PanelR6.SetActive(false);
        PanelR7.SetActive(false);
        PanelR8.SetActive(false);
        PanelR9.SetActive(false);
        PanelR10.SetActive(false);
        PanelR11.SetActive(false);
        PanelR12.SetActive(false);
        PanelR13.SetActive(false);


        caseValue.Add(0.01);
        caseValue.Add(1);
        caseValue.Add(5);
        caseValue.Add(10);
        caseValue.Add(25);
        caseValue.Add(50);
        caseValue.Add(75);
        caseValue.Add(100);
        caseValue.Add(200);
        caseValue.Add(300);
        caseValue.Add(400);
        caseValue.Add(500);
        caseValue.Add(750);
        caseValue.Add(1000);
        caseValue.Add(5000);
        caseValue.Add(10000);
        caseValue.Add(25000);
        caseValue.Add(50000);
        caseValue.Add(75000);
        caseValue.Add(100000);
        caseValue.Add(200000);
        caseValue.Add(300000);
        caseValue.Add(400000);
        caseValue.Add(500000);
        caseValue.Add(750000);
        caseValue.Add(1000000);



        for (int i = 0; i < 26; i++)
        {

            int r = UnityEngine.Random.Range(0, caseValue.Count);
            cases.Add(caseValue[r]);
            cashLeft.Add(caseValue[r]);
            caseValue.Remove(caseValue[r]);


        }
        playerChoices = 0;
    }

    // Update is called once per frame
    void Update()
    {
        casesLeft();
    }
    public void btnClick(int numb)
    {
        if (playerChoices >= 1)
        {

            if (Convert.ToString(cases[numb]) == (panelL1.text))
            {
                PanelL1.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }

            }
            else if (Convert.ToString(cases[numb]) == (panelL2.text))
            {
                PanelL2.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL3.text))
            {
                PanelL3.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL4.text))
            {
                PanelL4.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL5.text))
            {
                PanelL5.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL6.text))
            {
                PanelL6.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL7.text))
            {
                PanelL7.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL8.text))
            {
                PanelL8.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL9.text))
            {
                PanelL9.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL10.text))
            {
                PanelL10.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL11.text))
            {
                PanelL11.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL12.text))
            {
                PanelL12.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelL13.text))
            {
                PanelL13.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR1.text))
            {
                PanelR1.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR2.text))
            {
                PanelR2.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR3.text))
            {
                PanelR3.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR4.text))
            {
                PanelR4.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR5.text))
            {
                PanelR5.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR6.text))
            {
                PanelR6.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR7.text))
            {
                PanelR7.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR8.text))
            {
                PanelR8.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR9.text))
            {
                PanelR9.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR10.text))
            {
                PanelR10.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR11.text))
            {
                PanelR11.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }
            }
            else if (Convert.ToString(cases[numb]) == (panelR12.text))
            {
                PanelR12.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }

            }
            else if (Convert.ToString(cases[numb]) == (panelR13.text))
            {
                PanelR13.SetActive(true);
                for (int i = 0; i < cashLeft.Count; i++)
                {
                    if (cashLeft[i] == cases[numb])
                    {
                        cashLeft.RemoveAt(i);
                    }
                }

            }
        }
    }
    public void btnOff(string caseNum)
    {
        if (playerChoices == 0)
        {

            if (caseNum == case1T.text)
            {
                case1.interactable = false;
                playerChoices++;
                playersCase.text = case1T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case2T.text)
            {
                case2.interactable = false;
                playerChoices++;
                playersCase.text = case2T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case3T.text)
            {
                case3.interactable = false;
                playerChoices++;
                playersCase.text = case3T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case4T.text)
            {
                case4.interactable = false;
                playerChoices++;
                playersCase.text = case4T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case5T.text)
            {
                case5.interactable = false;
                playerChoices++;
                playersCase.text = case5T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case6T.text)
            {
                case6.interactable = false;
                playerChoices++;
                playersCase.text = case6T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case7T.text)
            {
                case7.interactable = false;
                playerChoices++;
                playersCase.text = case7T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case8T.text)
            {
                case8.interactable = false;
                playerChoices++;
                playersCase.text = case8T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case9T.text)
            {
                case9.interactable = false;
                playerChoices++;
                playersCase.text = case9T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case10T.text)
            {
                case10.interactable = false;
                playerChoices++;
                playersCase.text = case10T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case11T.text)
            {
                case11.interactable = false;
                playerChoices++;
                playersCase.text = case11T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case12T.text)
            {
                case12.interactable = false;
                playerChoices++;
                playersCase.text = case12T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case13T.text)
            {
                case13.interactable = false;
                playerChoices++;
                playersCase.text = case13T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case14T.text)
            {
                case14.interactable = false;
                playerChoices++;
                playersCase.text = case14T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case15T.text)
            {
                case15.interactable = false;
                playerChoices++;
                playersCase.text = case15T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case16T.text)
            {
                case16.interactable = false;
                playerChoices++;
                playersCase.text = case16T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case17T.text)
            {
                case17.interactable = false;
                playerChoices++;
                playersCase.text = case17T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case18T.text)
            {
                case18.interactable = false;
                playerChoices++;
                playersCase.text = case18T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case19T.text)
            {
                case19.interactable = false;
                playerChoices++;
                playersCase.text = case19T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case20T.text)
            {
                case20.interactable = false;
                playerChoices++;
                playersCase.text = case20T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case21T.text)
            {
                case21.interactable = false;
                playerChoices++;
                playersCase.text = case21T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case22T.text)
            {
                case22.interactable = false;
                playerChoices++;
                playersCase.text = case22T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case23T.text)
            {
                case23.interactable = false;
                playerChoices++;
                playersCase.text = case23T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case24T.text)
            {
                case24.interactable = false;
                playerChoices++;
                playersCase.text = case24T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case25T.text)
            {
                case25.interactable = false;
                playerChoices++;
                playersCase.text = case25T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            else if (caseNum == case26T.text)
            {
                case26.interactable = false;
                playerChoices++;
                playersCase.text = case26T.text;
                playersCaseValue = cases[Convert.ToInt32(caseNum) - 1];
            }
            playersCase2.text = playersCase.text;
        }
        else if (playerChoices >= 1)
        {

            if (caseNum == case1T.text)
            {
                case1.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case2T.text)
            {
                case2.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case3T.text)
            {
                case3.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case4T.text)
            {
                case4.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case5T.text)
            {
                case5.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case6T.text)
            {
                case6.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case7T.text)
            {
                case7.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case8T.text)
            {
                case8.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case9T.text)
            {
                case9.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case10T.text)
            {
                case10.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case11T.text)
            {
                case11.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case12T.text)
            {
                case12.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case13T.text)
            {
                case13.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case14T.text)
            {
                case14.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case15T.text)
            {
                case15.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case16T.text)
            {
                case16.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case17T.text)
            {
                case17.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case18T.text)
            {
                case18.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case19T.text)
            {
                case19.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case20T.text)
            {
                case20.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case21T.text)
            {
                case21.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case22T.text)
            {
                case22.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case23T.text)
            {
                case23.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case24T.text)
            {
                case24.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case25T.text)
            {
                case25.interactable = false;
                playerChoices++;
            }
            else if (caseNum == case26T.text)
            {
                case26.interactable = false;
                playerChoices++;
            }
        }
    }

    public void casesLeft()
    {
        if (playerChoices >= 1 && playerChoices < 7)
        {
            casesRemaining.text = Convert.ToString(7 - playerChoices);
        }
        else if (playerChoices >= 6 && playerChoices < 12)
        {
            casesRemaining.text = Convert.ToString(12 - playerChoices);
        }
        else if (playerChoices >= 11 && playerChoices < 16)
        {
            casesRemaining.text = Convert.ToString(16 - playerChoices);
        }
        else if (playerChoices >= 15 && playerChoices < 19)
        {
            casesRemaining.text = Convert.ToString(19 - playerChoices);
        }
        else if (playerChoices >= 18 && playerChoices < 21)
        {
            casesRemaining.text = Convert.ToString(21 - playerChoices);
        }
        else if (playerChoices >= 21 && playerChoices < 25)
        {
            casesRemaining.text = "1";
        }
    }
    public void banksResponse()
    {
        remains = 0;
        for (int i = 0; i < cashLeft.Count; i++)
        {
            remains = remains + cashLeft[i];
        }
        cash = Convert.ToInt32(remains);


    }
}
