using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class HostMenu : MonoBehaviour
{
    [SerializeField] private Slider playerSliderObject;
    [SerializeField] private TMP_InputField gameNameInputField;
    [SerializeField] private TMP_InputField gamePasswordInputField;
    private int _playerCount = 6;
    private string _gameName;
    private string _gamePassword;

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
    
    public int GetPlayerCount()
    {
        return _playerCount;
    }
}