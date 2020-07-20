
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadingScene : MonoBehaviour {

	public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }

    public void StartFightingScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
