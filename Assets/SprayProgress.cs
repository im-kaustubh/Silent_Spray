using UnityEngine;
using UnityEngine.UI;

public class SprayProgress : MonoBehaviour
{
    public Slider spraySlider;
    public float sprayTime = 3f; // How long to fully spray
    private float sprayTimer = 0f;
    private bool isSpraying = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.E))
        {
            isSpraying = true;
            sprayTimer += Time.deltaTime;
            spraySlider.value = sprayTimer / sprayTime;

            if (sprayTimer >= sprayTime)
            {
                Debug.Log("✅ Spray completed!");
                sprayTimer = 0f;
                spraySlider.value = 0f;
                // You can trigger a mission complete or artwork shown here
            }
        }
        else
        {
            if (isSpraying)
            {
                isSpraying = false;
                sprayTimer = 0f;
                spraySlider.value = 0f;
                Debug.Log("🛑 Spray canceled.");
            }
        }
    }
}
