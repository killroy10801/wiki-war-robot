using UnityEngine;

// Generate a screenshot and save to disk with the name WarRobot.png.

public class ScreenShot : MonoBehaviour
{
    void OnMouseDown()
    {
        ScreenCapture.CaptureScreenshot("WarRobot");
    }
}