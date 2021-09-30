using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit(); // quit the game
        Debug.Log("Quit The Game.");
    }
}
