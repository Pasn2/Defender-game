using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class FollowPath : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] float speed;
    [SerializeField] float damage;
    [SerializeField] float maxDistanceToWeb;
    [SerializeField] string targetToSearch;
    float currentDistanceToWeb;
    void Start()
    {
        target = GameObject.FindGameObjectWithTag(targetToSearch).transform;
    }
    void Update()
    {        
        if(target != null){
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position,speed * Time.deltaTime);
        }
    }
    public void ChangeTarget(Transform _target,Transform startpos,float _delay){
        gameObject.transform.position = startpos.position;
        target = _target;
    }
}
