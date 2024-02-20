using UnityEngine;
using TMPro;
public class FullScreenButton : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ToggleFullScreen();
        }
    }

    private void ToggleFullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
        _text.text = "this fullscreen is when the space button is pressed";
    }
}
