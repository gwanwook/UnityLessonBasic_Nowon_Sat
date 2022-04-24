using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    // this 키워드
    // 객체 자신을 반환하는 키워드

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
        // position 변경시에는
        // position 의 프레임시간당 변화량을 더해주어야 한다.
        // 시간당 위치 변화량(속도) = 위치변화량 / 시간
        // 프레임시간당 위치 변화량(프레임단위 속도) = 위치변화량 / 프레임시간
        // 위치변화량 = 프레임시간당 위치변화량 * 프레임시간

        tr.position += move * Time.fixedDeltaTime;
    }
}
