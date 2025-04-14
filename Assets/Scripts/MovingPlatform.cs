using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
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
        direction = Vector3.left;

        leftStart = leftPoint.position;
        rightStart = rightPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        PlatformMove();
    }

    /// <summary>
    /// move the platform left or right until it reaches the left/RIght point then chage directions
    /// </summary>
    private void PlatformMove()
    {
        //move
        transform.position += direction * speed * Time.deltaTime;

        //check if platform moved more than rightPoint on the x axis
        if (transform.position.x >= rightStart.x)
        {
            direction = Vector3.left;
        }

        //check if platform moved more than rightPoint on the x axis
        if (transform.position.x <= leftStart.x)
        {
            direction = Vector3.right;
        }
    }

}
