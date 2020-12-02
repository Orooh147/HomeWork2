using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    float pHealth;

    void Start()
    {
        pHealth = SingleTone.Instance.Health;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Tookdmg(pHealth);
        }
        Debug.Log(pHealth);
    }

    public float Tookdmg(float damage)
    {
        damage = 15;
        pHealth -= damage;
        if (pHealth <=0)
        {
            Die();
            Debug.Log("Died");
        }

        return damage;
            //Tookdmg(pHealth);
    }

    void Die()
    {
        Instantiate(this.gameObject);
        Instantiate(this.gameObject);
        Destroy(this.gameObject);
    }
}
