
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;
using Unity.VisualScripting;


public class FireCtrl : MonoBehaviour
{
    public const float BULLET_DISTANCE = 50.0f;
   public GameObject bullet;
    // 총알 발사 좌표
    public Transform firePos;
   
    private MeshRenderer muzzleFlash;
    void Start()
    {
        // FirePos 하위에 있는 MuzzleFlash의 머터리얼 컴포넌트 추출
        muzzleFlash = firePos.GetComponentInChildren<MeshRenderer>();
        // 처음 시작할떄 비활성
        muzzleFlash.enabled = false;
    }

    public void OnPlayerDie()
    {

    }
    void Update()
    {
        // Ray를 시각적으로 표시하기 위해 사용
        Debug.DrawRay(firePos.position, firePos.forward * BULLET_DISTANCE, Color.green);

        // 마우스 왼쪽 버튼을 클릭했을때 Fire 함수 호출
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
    }
    }
    void Fire()
    {
        // Bullet 프리팹을 동적으로 생성 (생성할 객체, 위치, 회전)
        Instantiate(bullet, firePos.position, firePos.rotation);
       
        StartCoroutine(ShowMuzzleFlash());

    }

    IEnumerator ShowMuzzleFlash()
    {
        // offset 좌표값을 랜덤 함수로 생성
        Vector2 offset = new Vector2(Random.Range(0, 2), Random.Range(0, 2)) * 0.5f;
        // Texture 의 offset 값 설정
        muzzleFlash.material.mainTextureOffset = offset;

        // MuzlleFlash 크기 조절
        float scale = 0.1f;
        muzzleFlash.transform.localScale = Vector3.one * scale;

        // MuzzleFlash 활성화
        muzzleFlash.enabled = true;
        // 0.2초 동안 대기하는 동안 메시지 루프로 제어권을 양보
        yield return new WaitForSeconds(0.2f);
        // MuzzleFlash 비활성화
        muzzleFlash.enabled = false;

    }
}
