using UnityEngine;

public class FullScreen : MonoBehaviour
{
    public void ToogleFullScreen(bool isFullScreen)
    {
        Screen.fullScreen = isFullScreen;
    }
}
