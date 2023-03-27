using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    public TextMeshProUGUI scoreBoard;

    private void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreBoard.SetText("Score: " + score);
    }
}
