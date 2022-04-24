using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // 키보드 화살표 왼쪽, 오른쪽 방향키로 X축으로 움직임
    // 키보드 화살표 위쪽, 아래쪽 방향키로 Z축으로 움직임

    //public GameObject go;
    Transform tr;
    public float speed = 1f;
    Vector3 move;

    private void Awake()
    {
        //tr = transform;
        tr = GetComponent<Transform>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        //move = new Vector3(h, 0, v).normalized; // 정규화
        move = new Vector3(h, 0, v);
    }

    private void FixedUpdate()
    {
        //tr.position += move * Time.fixedDeltaTime;
        tr.Translate(move * speed * Time.fixedDeltaTime);
    }
}
