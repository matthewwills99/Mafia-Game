using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    [SerializeField] private Slider volumeSliderObject;
    [SerializeField] private Slider graphicsSliderObject;
    private int _volumeLevel = 50;
    private int _graphicsQuality = 1;

    public void VolumeSliderValueChanged()
    {
        _volumeLevel = (int) volumeSliderObject.value;
        Debug.Log("Volume level updated to: " + _volumeLevel);
    }
    public void GraphicsSliderValueChanged()
    {
        _graphicsQuality = (int) graphicsSliderObject.value;
        Debug.Log("Graphics quality updated to: " + _graphicsQuality);
    }
}