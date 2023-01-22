using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCard : MonoBehaviour
{
    [SerializeField] float healthAmount;
    void Start()
    {
        Destroy(gameObject,1f);
        HealthServer();
    }

    void HealthServer(){
       RaycastHit2D checkServer = Physics2D.CircleCast(transform.position,0.1f,Vector2.zero);
       if(checkServer.collider != null){
            checkServer.collider.GetComponent<Server>().Health(healthAmount);
       }
    }
}
