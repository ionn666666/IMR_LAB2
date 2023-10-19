using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameScript : MonoBehaviour
{
    public int totalScore = 0;
    public TMP_Text scoreText;
    private int maxPoints = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Welcome to the game, try to hit the blue holes :) ";
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    public void AddPoints ( int pts)
    {
        maxPoints += 5;
        totalScore += pts;
        scoreText.text = "Score : " + totalScore + ", out of max: " + maxPoints;
    }
}
