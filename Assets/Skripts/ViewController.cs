using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewController : MonoBehaviour
{
    public Text score;
    public Text dinoLevel;
    public Text numLevel;
    public Text solarsystemLevel;
    public Text alphabetLevel;
    public Text aliceLevel;

    public int overallScore = 0;
    public int dinoScore = 0;
    public int numScore = 0;
    public int ssScore = 0;
    public int alphaScore = 0;
    public int aliceScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        score.text = ScoreController.overallScore;
    }

    // Update is called once per frame
    void Update()
    {
        score.text = ScoreController.overallScore;
        dinoLevel.text = ScoreController.dinoScore;
        numLevel.text = ScoreController.numScore;
        solarsystemLevel.text = ScoreController.ssScore;
        alphabetLevel.text = ScoreController.alphaScore;
        aliceLevel.text = ScoreController.aliceScore;
    }

    public void DinoScore()
    {
        dinoScore++;
        overallScore += 5;
        ScoreController.dinoScore = dinoScore.ToString();
        ScoreController.overallScore = overallScore.ToString();
    }

    public void NumScore()
    {
        int prScore;
        prScore = overallScore;
        numScore++;
        prScore += 10;
        //SlowRotation();
        //overallScore += 10;
        ScoreController.numScore = numScore.ToString();
        while (overallScore <= prScore)
        {
            ScoreController.overallScore = overallScore.ToString();
            overallScore++;
        }
    }

    public void SolarSystemScore()
    {
        ssScore++;
        overallScore += 15;
        ScoreController.ssScore = ssScore.ToString();
        ScoreController.overallScore = overallScore.ToString();
    }

    public void AlphabetScore()
    {
        alphaScore++;
        overallScore += 5;
        ScoreController.alphaScore = alphaScore.ToString();
        ScoreController.overallScore = overallScore.ToString();
    }

    public void AliceScore()
    {
        aliceScore++;
        overallScore += 7;
        ScoreController.aliceScore = aliceScore.ToString();
        ScoreController.overallScore = overallScore.ToString();

    }
}
