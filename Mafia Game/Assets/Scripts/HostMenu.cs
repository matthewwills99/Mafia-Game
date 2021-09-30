using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class HostMenu : MonoBehaviour
{
    [SerializeField] private Slider playerSliderObject;
    [SerializeField] private TMP_InputField gameNameInputField;
    [SerializeField] private TMP_InputField gamePasswordInputField;
    [SerializeField] private TMP_Text errorMessage;
    private int _playerCount = 6;
    private string _gameName = null;
    private string _gamePassword = null;

    public void PlayerSliderValueChanged()
    {
        _playerCount = (int) playerSliderObject.value;
        Debug.Log("Player count updated to: " + _playerCount);
    }
    public void GameNameInputValueChanged()
    {
        _gameName = gameNameInputField.text;
        Debug.Log("Game name updated to: " + _gameName);
    }
    public void GamePasswordInputValueChanged()
    {
        _gamePassword = gamePasswordInputField.text;
        Debug.Log("Game password updated to: " + _gamePassword);
    }

    public void OnGo()
    {
        if(_gameName == null || _gamePassword == null)
        {
            errorMessage.gameObject.SetActive(true);
            Debug.Log("Failed");
        }
        else
        {
            errorMessage.gameObject.SetActive(false);
            Debug.Log("Success");
            SceneManager.LoadScene("Lobby");
        }
    }
    
    public int GetPlayerCount()
    {
        return _playerCount;
    }
}