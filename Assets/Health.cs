using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{

    [SerializeField] int _health;
    
    

    public void Damage(int  bulletDamage)
    {
        _health = _health - bulletDamage;
        if(_health == 0) 
        {
            Debug.Log("l'ennemi est dead");
            GameObject.Destroy(gameObject);
        }
            
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
