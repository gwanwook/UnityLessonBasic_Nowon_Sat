using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Transform tr;
    public float moveSpeed;
    Vector3 move;

    private void Awake()
    {
        tr = transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        move = new Vector3(h, 0, v);
    }

    private void FixedUpdate()
    {
        tr.position += move * Time.fixedDeltaTime;
    }
}
