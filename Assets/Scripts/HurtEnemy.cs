using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemy : MonoBehaviour
{
    [SerializeField]
    int hurtAmount = 1;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        EnemyHealth ehealth = collider.gameObject.GetComponent<EnemyHealth>();
        if (ehealth == null)
        {
            return;
        }

        ehealth.Hurt(hurtAmount);
        Destroy(gameObject);
    }
}
