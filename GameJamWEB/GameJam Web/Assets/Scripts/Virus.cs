using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour,IDamagable
{
    [SerializeField] int damage;

    public void Dead()
    {
        Destroy(gameObject);
    }

    public void Health(float _health)
    {
        
    }

    public void TakeDamage(float _damage)
    {
        throw new System.NotImplementedException();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Server" || other.collider.tag == "AntyVirus"){
            IDamagable damageableObject = other.collider.GetComponent<IDamagable>();
            if(damageableObject != null){
                damageableObject.TakeDamage(damage);
                Destroy(gameObject);
            }
            
        }
    }
}
