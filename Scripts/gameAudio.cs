using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

/*
Alex Ato 
9-25-2020
Project 2
Design a game, gameplay wise, to be identically based off the Tv Game Show Deal or No Deal. We get to choose our themes and design how it appears but overall it should be a remake of Deal or No Deal
*/


public class gameAudio : MonoBehaviour
{
    public AudioClip[] music;
    
    public GameObject audioManager;
    public AudioSource music1;
    public AudioClip sound;
    public bool musicOn = true;
    int counter =0;
    
    void Start(){
     music1 = GetComponent<AudioSource>();
     sound = music[counter];
     music1.clip = sound;
     music1.Play();
    
    }
    void Update()
    {
        
    }
    public void PauseBtn(){
        if(musicOn == true){
            music1.Pause();
            musicOn = false;
        }else if(musicOn == false){
            musicOn = true;
            music1.Play();
        }
        
    }
    public void nextSong(){
        counter++;
        if (counter > music.Length - 1){
            music1.Pause();
            counter = 0;
            sound = music[counter];
            music1.clip = sound;
            music1.Play();
        }else{
            music1.Pause();
            sound = music[counter];
            music1.clip = sound;
            music1.Play();
            
        }


        
        
       // sound = music[counter];
       // music1.clip = sound;
        
    }
}
