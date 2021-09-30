using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LobbyScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField usernameInputField;

    private string _username;

    public void UsernameInputValueChanged()
    {
        _username = usernameInputField.text;
        Debug.Log("Username updated to: " + _username);
    }
}
