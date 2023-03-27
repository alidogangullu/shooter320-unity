using TMPro;
using UnityEngine;

public class UIScore : MonoBehaviour
{
    private int score;
    public static int totalScore;
    public TextMeshProUGUI scoreBoard;
    void Start()
    {
        score = Score.score;
        totalScore += score; 
        scoreBoard.SetText("Score: " + score);
        if (PlayerHP.Level == "Level1" || PlayerHP.Level == "Level2" || PlayerHP.Level == "Level3" || PlayerHP.Level == "Level4")
        {
            scoreBoard.SetText(" ");
        }
    }
}
