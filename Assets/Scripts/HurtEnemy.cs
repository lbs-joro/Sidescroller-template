using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    [SerializeField]
    int hurtAmount = 1;

    [SerializeField]
    bool destroyOnTouch = true;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyHealth ehealth = collider.gameObject.GetComponent<EnemyHealth>();
        if (ehealth == null)
        {
            return;
        }

        ehealth.Hurt(hurtAmount);

        if (destroyOnTouch)
        {
            Destroy(gameObject);
        }
        
    }
}
