using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletProjectile : MonoBehaviour
{
    private Rigidbody bulletRb;

    [SerializeField] private float speed = 10f;

    void Awake()
    {
        bulletRb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        bulletRb.linearVelocity = transform.forward * speed;
        //DestoySelf();
    }
    private void DestoySelf()
    {
        Destroy(gameObject, 2f);
    }
}
