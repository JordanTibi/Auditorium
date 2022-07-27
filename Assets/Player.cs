

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

     [SerializeField] Rigidbody _rigidbody;
     [SerializeField] float _speed;
     [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _bulletSpawnPoint;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       float vertical = Input.GetAxis("Vertical");
       float horizontal = Input.GetAxis("Horizontal");

       Vector3 direction = new Vector3(horizontal, 0, vertical)* _speed;

        //GameObject _bulletPrefab;

        

        if(Input.GetKeyDown("space"))
        {
            Debug.Log("Test ok");
            GameObject.Instantiate(_bulletPrefab, _bulletSpawnPoint.position, _bulletSpawnPoint.rotation);
        }

        // Methode 1


        //transform.Translate(direction);

        // Methode 2 
        Vector3 futurPosition = transform.position + direction;
        Debug.DrawRay(transform.position, direction*5, Color.red);
        _rigidbody.MovePosition(futurPosition);

        // ROTATION //

        float aimHorizontal = Input.GetAxis("AimHorizontal");
        float aimVertical = Input.GetAxis("AimVertical");
        Vector3 aimDirection = new Vector3(aimHorizontal , 0 , aimVertical);
        transform.LookAt(transform.position + aimDirection);

    }
}
