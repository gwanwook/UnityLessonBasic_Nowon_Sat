using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == null) { return; }

        Debug.Log(collision.gameObject.name);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"triggerd! {other.gameObject.name}");

        //Destroy(gameObject);


    }

    public GameObject destroyEffect;

    public void DoDestroyEffect()
    {
        GameObject go = Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(go, 3);
    }
}
