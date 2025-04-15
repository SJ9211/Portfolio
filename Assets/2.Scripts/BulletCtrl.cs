using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    public float damage = 20.0f;
    public float force = 3000.0f;

    private Rigidbody rb;
    private Transform tr;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        rb.AddForce(transform.forward * force);
    }


     void OnTriggerEnter(Collider other)
    {
        // 충돌한 오브젝트가 Zombie 일 경우 해당 오브젝트에 데미지를 줌
        if ( other.gameObject.tag == "ZOMBIE")
        {
            Debug.Log("ZOMBIE");

            // 몬스터 피해
            other.GetComponent<MonsterCtrl>();
        }
        // 충돌 총알 제거
        Destroy(tr.gameObject);
    }
}
