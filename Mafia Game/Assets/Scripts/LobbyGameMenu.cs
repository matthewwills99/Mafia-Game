using UnityEngine;

public class LobbyGameMenu : MonoBehaviour
{
       public void QuitGame()
    {
        Application.Quit(); // quit the game
        Debug.Log("Quit the game.");
    }
}
