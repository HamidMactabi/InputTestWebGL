using UnityEngine;
using TMPro;

public class FullScreenEvent : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void ToggleFullscreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        _text.text = "event fullscreen applied";
    }
}
