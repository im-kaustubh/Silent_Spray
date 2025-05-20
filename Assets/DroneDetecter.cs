using UnityEngine;

public class DroneDetector : MonoBehaviour
{
    public SprayProgress sprayProgress;
    public GameOverManager gameOverManager;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Drone"))
        {
            PlayerHide playerHide = GetComponent<PlayerHide>();

            // Check if sprayProgress or gameOverManager is missing
            if (sprayProgress == null)
            {
                Debug.LogWarning("🚫 sprayProgress is not assigned!");
                return;
            }

            if (gameOverManager == null)
            {
                Debug.LogWarning("🚫 gameOverManager is not assigned!");
                return;
            }

            if (playerHide != null && playerHide.isHiding)
            {
                Debug.Log("😎 Player is hiding — safe from drone");
                return;
            }

            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("🚨 Drone spotted you spraying! You're caught!");
                gameOverManager.TriggerGameOver();
            }
        }
    }
}
