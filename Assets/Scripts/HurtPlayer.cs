using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    [SerializeField]
    int hurtAmount = 1;

    [SerializeField]
    AudioClip hurtSound;

    [SerializeField]
    GameObject deathObject;

    [SerializeField]
    bool destroyOnTouch = true;

    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }



    private void OnTriggerEnter2D(Collider2D collider)
    {
        PlayerHealth phealth = collider.gameObject.GetComponent<PlayerHealth>();
        if (phealth == null)
        {
            return;
        }

        phealth.Hurt(hurtAmount);

        if (destroyOnTouch)
        {
            Destroy(gameObject);
        }
        
    }
}
