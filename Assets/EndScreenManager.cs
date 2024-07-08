using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndScreenManager : MonoBehaviour
{

    public Text scoreText;
    public Button restartButton;
    public GameObject endScreen;
   
    void Start()
    {
        endScreen.SetActive(false);

        restartButton.onClick.AddListener(RestartGame);
    }

    public void ShowEndScreen(String score)
    {
        endScreen.SetActive(true);
        HideAllExceptEndScreen();

        scoreText.text = "Your score is: " + score;
    }

    private void RestartGame()
    {
        // Reload the current scene to restart the game
       //SceneManager.LoadScene("SampleScene");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void HideAllExceptEndScreen()
    {
        // Find all root GameObjects in the scene
        GameObject[] allObjects = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();

        // Loop through each object and deactivate it unless it's the end screen
        foreach (GameObject obj in allObjects)
        {
            if (obj != this.gameObject && obj != endScreen.gameObject && obj.name != "Main Camera" && obj.name != "EndScreenManager" && obj.name != "EventSystem")
            {
                obj.SetActive(false);
            }
        }
    }
}
