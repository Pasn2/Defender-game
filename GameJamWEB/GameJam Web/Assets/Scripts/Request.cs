using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Request : MonoBehaviour
{
    [SerializeField] int moneyAdded;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag == "Server"){
            GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().AddMoney(moneyAdded);
            Destroy(gameObject); 
        }
    }
}
