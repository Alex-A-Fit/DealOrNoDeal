using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

/*
Alex Ato 
9-25-2020
Project 2
Design a game, gameplay wise, to be identically based off the Tv Game Show Deal or No Deal. We get to choose our themes and design how it appears but overall it should be a remake of Deal or No Deal
*/


public class AudioScript : MonoBehaviour
{
    public AudioSource audioClip;
    int count = 0;

    // Start is called before the first frame update
    void Awake() {
        audioClip = GameObject.Find("AudioManager").GetComponent<AudioSource>();
        audioClip.Play();
    }
  
   
    public void toggleMusic(){
        count++;
        if(count % 2 == 1){
            audioClip.Stop();
        }
        else if (count % 2 == 0){
            audioClip.Play();
        }
        
    }
    public void musicOff(){
        audioClip.Stop();
    }

}
