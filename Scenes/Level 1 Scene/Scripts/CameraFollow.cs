using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float followSpeed;
    public Transform target;
    public float yPosOffSet;
    // Update is called once per frame
    void Update()
    {
        Vector3 position = new Vector3(target.position.x, target.position.y + yPosOffSet, -10f);
        transform.position = Vector3.Slerp(transform.position, position, followSpeed * Time.deltaTime);
    }
}
