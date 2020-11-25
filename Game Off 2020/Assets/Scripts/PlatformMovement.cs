using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    private Vector3 posA;
    private Vector3 posB;
    private Vector3 nextPos;
    public float speed = 2f;

    public Transform elevatorTransform;
    public Transform pointToGoTransform;

    void Start()
    {
        posA = elevatorTransform.localPosition;
        posB = pointToGoTransform.localPosition;
        nextPos = posB;
    }

    void Update()
    {
        Move();
    }

    public void Move() 
    {
        elevatorTransform.localPosition = Vector3.MoveTowards(elevatorTransform.localPosition, nextPos, speed * Time.deltaTime);

        if (Vector3.Distance(elevatorTransform.localPosition, nextPos) <= 0.1) 
        {
            ChangeNextPos();
        }
    }

    public void ChangeNextPos() 
    {
        if (nextPos != posA)
        {
            nextPos = posA;
        }
        else 
        {
            nextPos = posB;
        }
    }
}
