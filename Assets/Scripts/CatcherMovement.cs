using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatcherMovement : MonoBehaviour
{
    public static float boundary = 2.5f;
    public float moveSpeed = 5f;
    public static Vector3 finger;
    public static Vector3 fingerPos;
    
    // Update is called once per frame
    void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            finger = touch.position;
            fingerPos = new Vector3(Camera.main.ScreenToWorldPoint(finger).x, -3.731f, 5);
            transform.position = fingerPos;
        }
    }
}
