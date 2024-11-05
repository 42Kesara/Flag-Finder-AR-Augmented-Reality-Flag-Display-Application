using UnityEngine;

public class FlagColorChanger : MonoBehaviour
{
    public Renderer flagRenderer;    // Assign this to the flag's Renderer in the Unity Inspector
    public Renderer flagpoleRenderer; // Assign this to the flagpole's Renderer in the Unity Inspector
    private Color[] colors = { Color.red, Color.green, Color.blue, Color.yellow }; // Add more colors if needed
    private int currentColorIndex = 0;

    void Start()
    {
        ChangeColor();
    }

    void ChangeColor()
    {
        // Change to the next color in the array
        flagRenderer.material.color = colors[currentColorIndex];
        flagpoleRenderer.material.color = colors[currentColorIndex];
        currentColorIndex = (currentColorIndex + 1) % colors.Length;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detect touch or click
        {
            ChangeColor();
        }
    }
}
