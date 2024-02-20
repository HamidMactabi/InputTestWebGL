using UnityEngine;

public class FullScreenToggle : MonoBehaviour
{
    public void ToggleFullScreen()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }
}
