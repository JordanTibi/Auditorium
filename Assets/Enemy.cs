using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] Transform _player;
    [SerializeField] float _speed;


    [SerializeField] GameObject _bulletPrefab;
    [SerializeField] Transform _spawnPoint;

    [SerializeField] float _cooldown;

    float _lastShoot;

    // Update is called once per frame
    void Update()
    {
        //Move to player
        Vector3 direction = (transform.position - _player.position);
        direction = new Vector3(direction.x, 0, direction.z);
        transform.Translate(direction * _speed * Time.deltaTime, Space.Self);

        //Rotation
        transform.LookAt(_player.position);
        transform.rotation = Quaternion.Euler(0, transform.rotation.eulerAngles.y, 0);

        // Shoot

        if(Time.time > _lastShoot + _cooldown)
        {
            _lastShoot = Time.time;
            GameObject.Instantiate(_bulletPrefab, _spawnPoint.position, _spawnPoint.rotation);
        }




    }
}
