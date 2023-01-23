using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Server : MonoBehaviour , IDamagable,ISpawnable,IHealable
{
    [SerializeField] float health;
    [SerializeField] float maxHealth;
    [SerializeField] TMP_Text displayHealthText;
    [SerializeField] Color hightLightColor;
    
    public void Health(float _healthAmount)
    {
        health += _healthAmount;
        if(health > maxHealth)
        {
            health = maxHealth;
        }
    }
    public void TakeDamage(float _damage)
    {
        health -= _damage;
        if(health <= 0){
            Dead();
            //GameManager.instance.CheckAmountOfServers();
        }
    }
    public void Dead()
    {
        Destroy(gameObject);
    }
    void Start()
    {
        health = maxHealth;
    }
    public void HighLightColor()
    {
        gameObject.GetComponent<SpriteRenderer>().color = hightLightColor;
    }
    public void NormalColor()
    {

    }
}
