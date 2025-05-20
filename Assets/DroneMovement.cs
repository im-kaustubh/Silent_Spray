using UnityEngine;

public class DroneMovement : MonoBehaviour
{
    public float speed = 2f;           // Speed of the drone
    public float patrolDistance = 4f;  // How far it moves from start point

    private Vector3 startPosition;
    private int direction = 1;         // 1 = right, -1 = left

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Move the drone in the current direction
        transform.Translate(Vector3.right * direction * speed * Time.deltaTime);

        // Flip the drone visually based on direction
        if (direction == 1)
            transform.localScale = new Vector3(1, 1, 1);   // Face right
        else
            transform.localScale = new Vector3(-1, 1, 1);  // Face left

        // Change direction if we've reached patrol limits
        if (transform.position.x > startPosition.x + patrolDistance)
        {
            direction = -1; // Start moving left
        }
        else if (transform.position.x < startPosition.x - patrolDistance)
        {
            direction = 1; // Start moving right
        }
    }
}
