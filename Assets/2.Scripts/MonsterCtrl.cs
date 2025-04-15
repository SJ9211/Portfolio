using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class MonsterCtrl : MonoBehaviour
{

    public static MonsterCtrl instance = null;

    public int MonsterMaxSpawnCount = 30; // 최대몬스터 생성수
    public int MonsterCurrentSpawnCount = 10; // 현재 몬스터 생성수

    public float chaseDelay = 2.0f; // 추격 딜레이
    public float chaseLinitDistance = 2.0f; // 추격제한

    public float MonsterMaxHp = 20.0f; // 몬스터 최대 체력

    public Transform player;
  
    void Awake()
    {
        if ( instance == null)
        {
            instance = this;
        }
    }

    void start()
    {
        // 플레이어 로드
        player = GameObject.FindGameObjectWithTag("PLAYER").transform;
        // 현재 몬스터 생성수 0으로 초기화
        MonsterCurrentSpawnCount = 0;

        // 추격 관련 정보 초기화
        chaseDelay = 2.0f;
        chaseLinitDistance = 2.0f;

        // 몬스터 최대 체력 초기화
        MonsterMaxHp = 20.0f;
    }

    // 플레이어가 몬스터 죽임
    public void KillMonster()
    {
        // 현재 몬스터 생성 수 감소
        MonsterCurrentSpawnCount--;
    }
}
