using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Virus : MonoBehaviour,IDamagable,IEntity
{
    [SerializeField] int damage;

    public void Dead()
    {
        Destroy(gameObject);
    }

    public void TakeDamage(float _damage)
    {
        throw new System.NotImplementedException();
    }
    public void Use(GameObject _target)
    {
        IDamagable damageableObject = _target.GetComponent<IDamagable>();
            if(damageableObject != null){
                damageableObject.TakeDamage(damage);
                Destroy(gameObject);
            }
    }
    
}
