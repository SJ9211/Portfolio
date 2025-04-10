using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGizmos : MonoBehaviour
{
    public Color _color = Color.yellow;
    public float _radius = 0.01f;

    void OnDrawGizmos()
    {
        // 기즈모 색상
        Gizmos.color = _color;
        // 구체 모양의 기즈모
        Gizmos.DrawSphere(transform.position,_radius);
    }
}
