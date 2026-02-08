using UnityEngine;
using TouchScript.Gestures;

public class SoundAccessorTouch : MonoBehaviour
{
    [SerializeField]
    private SoundID hoverSound;
    
    [SerializeField]
    private SoundID clickSound;
    
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
            SoundManager.Instance.PlaySound2D(clickSound);
        }
    }
}
