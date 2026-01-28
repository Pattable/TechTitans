using UnityEngine;

public class ObjectToggler : MonoBehaviour
{
    public SoundID toggleSound;

    public GameObject[] itemsToToggle;

    public GameObject limiter;

    void Update()
    {
        if (limiter != null && !limiter.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                foreach (var item in itemsToToggle)
                {
                    item.SetActive(!item.activeSelf);
                }

                SoundManager.Instance.PlaySound2D(toggleSound);
            }
        }
    }
}
