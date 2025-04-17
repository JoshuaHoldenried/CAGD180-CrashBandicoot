using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Joshua Holdenried
 * First Updated: 4/10/25
 * Last Updated: 4/10/25
 * Handles the enemy movement from left to right while on the ground
 */

public class EnemyMovement : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public Transform leftPoint;
    public Transform rightPoint;

    private Vector3 leftStart;
    private Vector3 rightStart;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.right;

        //Store the starting position values of the left and right points
        leftStart = leftPoint.position;
        rightStart = rightPoint.position;   

    }

    // Update is called once per frame
    void Update()
    {
        EnemyMove();
    }

    /// <summary>
    /// Move the enemy left or right until it reaches the Left/Right point then change the direction
    /// </summary>
    private void EnemyMove()
    {
        transform.position += direction * speed * Time.deltaTime;

        // Check if the enemy reached the right point on the X axis
        if (transform.position.x >= rightStart.x)
        {
            direction = Vector3.left;
        }

        if (transform.position.x <= leftStart.x)
        {
            direction = Vector3.right;
        }
    }
}
