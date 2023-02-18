using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request : MonoBehaviour,IUse
{
    [SerializeField] int moneyAdded;
    public void Use(GameObject _target)
    {
        print("KK");
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().AddCapacity(moneyAdded);
        Destroy(gameObject); 
    }
    
}
