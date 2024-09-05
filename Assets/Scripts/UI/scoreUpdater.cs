using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;

public class scoreUpdater : MonoBehaviour
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
        text.text = "Current score :" + ScoreManager.score +  "\n" + "The current highscore is :" + ScoreManager.scoreList.First().Score();
    }
}
