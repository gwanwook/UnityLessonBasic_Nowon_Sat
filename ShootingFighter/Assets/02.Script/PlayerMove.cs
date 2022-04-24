using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Ű���� ȭ��ǥ ����, ������ ����Ű�� X������ ������
    // Ű���� ȭ��ǥ ����, �Ʒ��� ����Ű�� Z������ ������

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
        //move = new Vector3(h, 0, v).normalized; // ����ȭ
        move = new Vector3(h, 0, v);
    }

    private void FixedUpdate()
    {
        //tr.position += move * Time.fixedDeltaTime;
        tr.Translate(move * speed * Time.fixedDeltaTime);
    }
}
