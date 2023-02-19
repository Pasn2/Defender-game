using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntyVirusCell : MonoBehaviour,IDamagable
{
    public void TakeDamage(float _damage)
    {
        Dead();
    }
    public void Health(float _health){}
    public void Dead(){
        Destroy(gameObject);
    }    
    private void OnCollisionEnter2D(Collision2D other) {
        print(other.collider.tag);
        switch(other.collider.tag){
            case "Opponent":
                other.collider.GetComponent<IDead>().Dead();
                Dead();
            break;
            case "Computer":
                other.collider.GetComponent<Computer>().RemoveInfection(30f);
                Dead();
            break;
        }
    }
    
    
}
