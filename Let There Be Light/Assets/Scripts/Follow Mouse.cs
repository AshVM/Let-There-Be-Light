using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    Vector3 pos;
    public float speed = 1.0f;
    public float horizontalDis = 70f;
    public float verticalDis = 50f;

    // Update is called once per frame
    void Update()
    {
        pos.x = Input.mousePosition.x - horizontalDis;
        pos.y = Input.mousePosition.y - verticalDis;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
