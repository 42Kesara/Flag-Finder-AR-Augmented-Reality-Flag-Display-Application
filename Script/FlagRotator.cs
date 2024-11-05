using UnityEngine;

public class FlagTapRotator : MonoBehaviour
{
    public float rotationAngle = 45f; // Degrees to rotate on each tap

    void Update()
    {
        // Check for a tap or click
        if (Input.GetMouseButtonDown(0)) // 0 is for left mouse button or single tap
        {
            // Rotate the flag by a fixed angle around the Y-axis
            transform.Rotate(0, rotationAngle, 0);
        }
    }
}
