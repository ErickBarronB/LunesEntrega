using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class menuManager : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openScreen(GameObject buttonOpen)
    {
        buttonOpen.SetActive(true);
    }

    public void closeScreen(GameObject buttonClose) 
    {
    buttonClose.SetActive(false);
    }

    public void scoreAdd()
    {
        playerScore newScore = new playerScore("Current Player", ScoreManager.score);
        ScoreManager.instance.AddScore(newScore);
    }
}
