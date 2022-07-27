using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody _rb;
    [SerializeField] float _speed;
    [SerializeField] int _damage;
    // Start is called before the first frame update
    void Start()
    {
        _rb.velocity = transform.TransformDirection(new Vector3(0, 0, _speed));
    }

    private void OnCollisionEnter (Collision collision)
    {
        GameObject.Destroy(gameObject);

        Health targetHealth = collision.gameObject.GetComponent<Health>();
        if(targetHealth != null)
        {
            targetHealth.Damage(_damage);
        }
    }
       
}
