using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameIsEnded = false;
    float delayTime = 2f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    public void EndGame() {
        if (!gameIsEnded) {
            gameIsEnded = true;

            //restart the game
            //Restart();
            Invoke("Restart",delayTime);
        }
    
    }

    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


}

