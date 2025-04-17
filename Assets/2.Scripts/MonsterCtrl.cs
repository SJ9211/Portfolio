using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.AI;
public class MonsterCtrl : MonoBehaviour
{

    
    public static MonsterCtrl instance = null;

    public Transform player;
  
    void Awake()
    {
        if ( instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
       

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
