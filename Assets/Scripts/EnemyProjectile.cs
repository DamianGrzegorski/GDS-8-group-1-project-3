﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] private int _damage = 1;
    [SerializeField] private float _lifeTime = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.GetComponent<ICharacter>() == null)
        {
            return;
        }

        collision.gameObject.GetComponent<ICharacter>().TakeDamage(_damage);
        //Debug.Log("Bullet collision with: " + collision.gameObject.name);
        Destroy(gameObject);
    }

    private void Update()
    {
        Destroy(gameObject, _lifeTime);
    }
}
