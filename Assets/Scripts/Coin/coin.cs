using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    // Start is called before the first frame update
    public int scoreToAdd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            addScore();
            Destroy(this.gameObject);
        }
    }

    public void addScore()
    {
        ScoreManager.score += scoreToAdd;
    }

    
}
