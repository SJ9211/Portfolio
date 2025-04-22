using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;

public class MonsterCtrl : MonoBehaviour
{

    public static MonsterCtrl instance = null;

     public Transform player;     // 추적할 플레이어
    public float speed = 3.0f;   // 이동 속도
    public float stopDistance = 1.5f; // 플레이어와의 최소 거리

    void Update()
    {
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.position);

            // 일정 거리 이상일 때만 추적
            if (distance > stopDistance)
            {
                Vector3 direction = (player.position - transform.position).normalized;
                transform.position += direction * speed * Time.deltaTime;

                // 몬스터가 플레이어를 바라보게 회전
                Quaternion toRotation = Quaternion.LookRotation(direction, Vector3.up);
                transform.rotation = Quaternion.Slerp(transform.rotation, toRotation, Time.deltaTime * 5f);
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if ( collision.collider.CompareTag("BULLET"))
        {
            // 충돌한 총알 삭제
            Destroy(collision.gameObject);
        }
    }

}
