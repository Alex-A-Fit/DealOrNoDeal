using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
Alex Ato 
9-25-2020
Project 2
Design a game, gameplay wise, to be identically based off the Tv Game Show Deal or No Deal. We get to choose our themes and design how it appears but overall it should be a remake of Deal or No Deal
*/


public class exitAndChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadScene(string sceneName){
    SceneManager.LoadScene(sceneName);
}
public void exit(){
    Application.Quit();
}
public void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
