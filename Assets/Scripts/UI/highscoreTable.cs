using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highscoreTable : MonoBehaviour
{
    // Start is called before the first frame update
    private TextMeshProUGUI text;
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>(); 
    }

    // Update is called once per frame
    void Update()
    {
        updateHighScoreTable();
    }




    public void updateHighScoreTable()
    {
        text.text = 
            "\n" + "Score 1 : " + ScoreManager.scoreList[0].ToString() + 
            "\n" + "Score 2 :" + ScoreManager.scoreList[1].ToString() +
            "\n" + " Score 3 :" + ScoreManager.scoreList[2].ToString() +
            "\n" + "Score 4 :" + ScoreManager.scoreList[3].ToString() + 
            "\n" + "score 5 :" + ScoreManager.scoreList[4].ToString() +
            "\n" + "score 6 :" + ScoreManager.scoreList[5].ToString() + 
            "\n" + "score 7 :" + ScoreManager.scoreList[6].ToString() + 
            "\n" + "score 8 :" + ScoreManager.scoreList[7].ToString() + 
            "\n" + "score 9 :" + ScoreManager.scoreList[8].ToString() + 
            "\n" + "score 10 :" + ScoreManager.scoreList[9].ToString()
            ;
    }
}
