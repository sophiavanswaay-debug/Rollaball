using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    public void PlayAgain()
    {
        // Must match the exact name of your game scene.
        SceneManager.LoadScene("MiniGame");
    }
}