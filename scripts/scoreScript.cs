using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreScript : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    private int score;
    public TextMeshProUGUI livesText;
    private int lives;
    
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        lives = 5;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = " Score : " + score;
        livesText.text = " Lives remaining : " + lives;
    }

    public void updateScore(int scoreToAdd)
    {
        score += scoreToAdd;
    }

    public void updateLives(int livesToAdd)
    {
        lives += livesToAdd;
    }
}
