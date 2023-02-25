using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCore : MonoBehaviour
{
    [SerializeField] GameObject[] serverTargets;
    [SerializeField] GameObject[] computerTargets;
    void Start()
    {
        RefreshTargets();
    }
    public void RefreshTargets(){
        serverTargets = GameObject.FindGameObjectsWithTag("Server");
        computerTargets = GameObject.FindGameObjectsWithTag("Computer");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        FollowPath followPathObject = other.gameObject.GetComponent<FollowPath>();
        if(followPathObject != null){
            RefreshTargets();
            switch(other.tag){
                case "Opponent":
                    ChangeDirection(serverTargets,followPathObject);
                break;
                case "Ally":
                    ChangeDirection(computerTargets,followPathObject);
                break;
            }
        }
    }
    void ChangeDirection(GameObject[] _possibleTargets,FollowPath _follow)
    {
        _follow.ChangeTarget(_possibleTargets[Random.Range(0,_possibleTargets.Length)].transform,gameObject.transform,1);
    }
}
