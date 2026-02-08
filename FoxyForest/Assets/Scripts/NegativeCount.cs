using UnityEngine;
using TouchScript.Gestures;

public class NegativeCount : MonoBehaviour
{
    public Counter counter;

    public GameObject allower;

    private PressGesture pressGesture;

    void Awake()
    {
       pressGesture = GetComponent<PressGesture>();
    }
    void OnEnable()
    {
        pressGesture.Pressed += PressedHandler;
    }

    void OnDisable()
    {
        pressGesture.Pressed -= PressedHandler;
    }

    private void PressedHandler(object sender, System.EventArgs e)
    {
        if (allower != null && allower.activeSelf)
        {
            //Debug.Log("Negative Cube Tapped!");
            counter.DecreaseCounter();
        }
    }
}
