using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Button startButton;
    public Button quitButton;
    
    private void Start() {
        startButton.onClick.AddListener(OnStartButtonClicked);
        quitButton.onClick.AddListener(OnQuitButtonClicked);
    }

    private void OnStartButtonClicked() {
        Debug.Log("Start Button Clicked");
        // Load the game scene or start the game
        SceneManager.LoadScene(1);
    }

    private void OnQuitButtonClicked() {
        Debug.Log("Quit Button Clicked");
        Application.Quit();
    }

}
