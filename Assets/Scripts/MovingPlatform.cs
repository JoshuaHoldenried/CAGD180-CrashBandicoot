using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3 direction;
    public float speed;
    public Transform fwdPoint;
    public Transform backPoint;

    private Vector3 fwdStart;
    private Vector3 backStart;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.forward;

        fwdStart = fwdPoint.position;
        backStart = backPoint.position;
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
        if (transform.position.z <= backStart.z)
        {
            direction = Vector3.forward;
        }

        //check if platform moved more than rightPoint on the x axis
        if (transform.position.z >= fwdStart.z)
        {
            direction = Vector3.back;
        }
    }

}
