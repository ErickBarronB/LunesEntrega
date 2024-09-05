using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScore
{
    string playerName;
    int score;

    public playerScore(string playerName, int score)
    {
        this.playerName = playerName;
        this.score = score;
    }

    public override string ToString()
    {
        return $"Player: {playerName}, Score: {score}";
    }   

    public int Score() { return score; }   
}
