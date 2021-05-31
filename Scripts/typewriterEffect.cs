using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class typewriterEffect : MonoBehaviour
{
    int currentlyDisplayingText = 0;
    public Button nextStep, previousStep;

    public Text goatTalkingText;
    //Store all your text in this string array
    string[] instructions = new string[]
    {"Step 1: When the game begins, 26 cases will appear and each case will contain a randomly assigned sum of money. Without any of the cases being revealed, choose one case at the start of the game. This case will then be removed from play until there are two cases remaining, including the case you chose" , "Step 2: Next choose any other case, one at a time, to be immediately opened and removed from play." , "Step 3: Throughout the game, you are offered an amount of money to quit playing the game. You are then asked the iconic question, \"Deal or No Deal?\". You can make one counter offer against the banker and if the banker agrees, you take the counter offer and the game ends!" , "Step 4: If you reject every deal and eliminate all the other cases besides the last one, excluding your case, you will be given one final offer to keep your case or switch it out for the last remaining case." , "Step 5: No matter what happens, you are going to walk away as a WINNER!"};
    void Awake()
    {
        StartCoroutine(AnimateText());
    }

    void Update() {
        switch (currentlyDisplayingText){
            case 0:
            previousStep.interactable = false;
            break;
            case 1:
            previousStep.interactable = true;
            break;
            case 3:
            nextStep.interactable = true;
            break;
            case 4:
            nextStep.interactable = false;
            break;
        }
    }

    public void SkipToNextText()
    {
        //This is a function for a button you press to skip to the next text
        StopAllCoroutines();
        ++currentlyDisplayingText;
        //If we've reached the end of the array, do anything you want. I just restart the example text
        if (currentlyDisplayingText < instructions.Length)
        {
            StartCoroutine(AnimateText());
        }
        else
        {
            currentlyDisplayingText = 0;
            StartCoroutine(AnimateText());
        }

    }

    public void goToPreviousText()
    {
        StopAllCoroutines();
        //If we've reached the end of the array, do anything you want. I just restart the example text
        if (currentlyDisplayingText == 0)
        {
            currentlyDisplayingText = 0;
            StartCoroutine(AnimateText());
        }
        else
        {
            currentlyDisplayingText--;
            StartCoroutine(AnimateText());
        }
    }

    //Note that the speed you want the typewriter effect to be going at is the yield waitforseconds (in my case it's 1 letter for every      0.03 seconds, replace this with a public float if you want to experiment with speed in from the editor)
    IEnumerator AnimateText()
    {

        for (int i = 0; i < (instructions[currentlyDisplayingText].Length + 1); i++)
        {
            goatTalkingText.text = instructions[currentlyDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(.02f);
        }
    }

























    // public float textSpeed = 0.1f;
    // public string fullText;
    // private string currentText = "";

    // public GameObject textDescription;

    // public GameObject gmMenu;

    // panelSettings panels;

    // // Start is called before the first frame update
    // void Awake() {
    //     gmMenu = GameObject.Find("Game Manager");
    //     panels = gmMenu.GetComponent<panelSettings>();
    //     StartCoroutine(ShowText());

    // }

    // void Update()
    // {

    // }

    // IEnumerator ShowText(){
    //     for(int i = 0; i<fullText.Length; i++){
    //         currentText = fullText.Substring(0,i);
    //         textDescription.GetComponent<Text>().text = currentText;
    //         yield return new WaitForSeconds (textSpeed);
    //     }
    // }

}
