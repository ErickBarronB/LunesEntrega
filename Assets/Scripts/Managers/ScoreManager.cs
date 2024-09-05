using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;
    public static List<playerScore> scoreList = new List<playerScore>();
    private const int MaxHighScores = 10;
    public static int score;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        // Add sample scores
        AddScore(new playerScore("Duncan", randomScore()));
        AddScore(new playerScore("Billy Bob Jones", randomScore()));
        AddScore(new playerScore("Richard Nixon", randomScore()));
        AddScore(new playerScore("Michael Jackson", randomScore()));
        AddScore(new playerScore("Carly", randomScore()));
        AddScore(new playerScore("James", randomScore()));
        AddScore(new playerScore("Leia", randomScore()));
        AddScore(new playerScore("Bal", randomScore()));
        AddScore(new playerScore("Christine", randomScore()));
        AddScore(new playerScore("Graggle Simpson", randomScore()));

        // Ensure the list is sorted and capped
        UpdateList();

        // Log the sorted list
        Debug.Log("High Scores:");
        foreach (var score in scoreList)
        {
            Debug.Log(score.ToString());
        }
    }

    public void AddScore(playerScore newScore)
    {

        if (scoreList.Count < MaxHighScores || newScore.Score() > scoreList.Last().Score())
        {
            
            scoreList.Add(newScore);
            
            UpdateList();


            foreach (var score in scoreList)
            {
                Debug.Log(score.ToString());
            }
        }
    }


    public void UpdateList()
    {
        
        
        scoreList = scoreList.OrderByDescending(ps => ps.Score()).ToList();

        
        if (scoreList.Count > MaxHighScores)
        {
            scoreList = scoreList.Take(MaxHighScores).ToList();
        }
    }

    public int randomScore()
    {
        return UnityEngine.Random.Range(0, 400);
    }
}
