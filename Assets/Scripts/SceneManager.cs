using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public void StartEndless()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("EndlessModeScene");
    }
    
    public void MainMenu()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("IntroMenu");
        }
    
    public void StartLevels()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Levels");
    }

    public void PlayAgain()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(PlayerHP.Level);
    }
    
    public void StartLevel1()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
    }
    
    public void StartLevel2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level2");
    }
    
    public void StartLevel3()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Level3");
    }
    
    public void Store()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Store");
    }
    
    public void StartLevel4()
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level4");
        }
}
