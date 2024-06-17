using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIscriptYaxis : MonoBehaviour
{
    public float movementSpeed;

    public GameObject pointA;

    public GameObject pointB;

    private Transform currentPoint;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        currentPoint = pointB.transform;
    }

    void Update()
    {
        Vector2 point = currentPoint.position - transform.position;

        if (currentPoint == pointB.transform)
        {
            rb.velocity = new Vector2(0, movementSpeed);
        }
        else
        {
            rb.velocity = new Vector2(0, -movementSpeed);
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointB.transform)
        {
            currentPoint = pointA.transform;
        }

        if (Vector2.Distance(transform.position, currentPoint.position) < 0.5f && currentPoint == pointA.transform)
        {
            currentPoint = pointB.transform;
        }
    }

}
