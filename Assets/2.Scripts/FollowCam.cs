using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
   // 따라가야 할 대상
   public Transform targetTr;

   private Transform camTr;

   [Range(2.0f, 20.0f)]
   public float distance = 10.0f;

   // y 축으로의 높이
   [Range(0.0f, 10.0f)]
   public float height = 2.0f;
    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        camTr.position = targetTr.position
                         + (-targetTr.forward * distance)
                         + (Vector3.up * height);

        camTr.LookAt(targetTr.position);
    }
}
