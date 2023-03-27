using TMPro;
using UnityEngine;

public class Level3 : MonoBehaviour
{
    public GameObject gateBox;
    public GameObject gateBoxTop;
    public TextMeshPro tutorial;
    public TextMeshPro tutorialTop;
    public TextMeshPro closeTop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Score.score == 5)
        {
            gateBox.SetActive(true);
            tutorial.SetText("Now you can use gate!");
        }
        
        if (Score.score == 10)
        {
            gateBoxTop.SetActive(true);
            Destroy(closeTop);
            tutorialTop.SetText("Now you can use gate!");
        }
    }
}
