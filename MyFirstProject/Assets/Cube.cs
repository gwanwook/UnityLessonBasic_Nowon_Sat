using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // this Ű����
    // ��ü �ڽ��� ��ȯ�ϴ� Ű����

    Vector3 move;

    public int a = 3;
    private Transform tr;

    private void Awake()
    {
        Debug.Log(this);
        Debug.Log(this.gameObject);
        Debug.Log(gameObject);

        //tr = this.gameObject.GetComponent<Transform>();
        //tr = gameObject.GetComponent<Transform>();
        //tr = GetComponent<Transform>();
        tr = transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        tr.position = Vector3.zero;
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log($"h = {h}, v = {v}");
        move = new Vector3(h, 0, v);

        //tr.position += Vector3.forward * Time.deltaTime;
        //tr.position += move * Time.deltaTime;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // position ����ÿ���
        // position �� �����ӽð��� ��ȭ���� �����־�� �Ѵ�.
        // �ð��� ��ġ ��ȭ��(�ӵ�) = ��ġ��ȭ�� / �ð�
        // �����ӽð��� ��ġ ��ȭ��(�����Ӵ��� �ӵ�) = ��ġ��ȭ�� / �����ӽð�
        // ��ġ��ȭ�� = �����ӽð��� ��ġ��ȭ�� * �����ӽð�

        tr.position += move * Time.fixedDeltaTime;
    }
}
