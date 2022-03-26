using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public LayerMask targetLayer;
    public int damage;
    public int score;

    private void Awake()
    {
        hp = hpMax;
    }

    /*private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == null) { return; }

        Debug.Log(collision.gameObject.name);
    }*/

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log($"triggerd! {other.gameObject.name}");

        //Destroy(gameObject);

        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            Player.instance.hp -= damage;
            //other.gameObject.GetComponent<Player>().hp -= damage;
            Destroy(gameObject);
        }
    }

    public GameObject destroyEffect;

    public void DoDestroyEffect()
    {
        GameObject go = Instantiate(destroyEffect, transform.position, Quaternion.identity);
        Destroy(go, 3);
    }

    /*private void OnDestroy()
    {
        if(Player.instance != null)
        {
            Player.instance.score += score;
        }
        
    }*/

    private int _hp;
    public int hp
    {
        set
        {
            if(value > 0)
            {
                _hp = value;
            }
            else
            {
                _hp = 0;
                Player.instance.score += score;
                DoDestroyEffect();
                Destroy(gameObject);
            }

            hpSlider.value = (float)_hp / hpMax;
        }

        get
        {
            return _hp;
        }
    }
    public int hpMax;
    public Slider hpSlider;

    
}
