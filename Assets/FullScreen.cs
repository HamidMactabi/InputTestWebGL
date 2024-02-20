using TMPro;
using UnityEngine;

public class FullScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    public void ToogleFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
        _text.text = "Toggle with dynamic bool pressed";
        Debug.Log("here");
    }
}
