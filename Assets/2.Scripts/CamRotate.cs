using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    public float rotSpeed = 200.0f;

    void Update()
    {
        float h = Input.GetAxis("Mouse X"); // 마우스의 x축 움직임을 감지
        float v = Input.GetAxis("Mouse Y"); // 마우스의 y축 움직임을 감지

        Vector3 dir = new Vector3( v, h , 0); // 회전방향.좌우를 바라보는것은 y축이 회전하는것, 위아래를 바라보는것은 x축이 회전하는것
    }
}
