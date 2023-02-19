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
        print(other.name);
        print("DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD");
        FollowPath followPathObject = other.gameObject.GetComponent<FollowPath>();
        print(followPathObject.name + " AWDAWDADAWDAWDAWDWA");
        if(followPathObject != null){
            RefreshTargets();
            switch(other.tag){
                case "Opponent":
                    ChangeDirection(serverTargets,followPathObject);
                    print("Changed opponent");
                break;
                case "Ally":
                    ChangeDirection(computerTargets,followPathObject);
                    print("Changed Ally");
                break;
            }
        }
    }
    void ChangeDirection(GameObject[] _possibleTargets,FollowPath _follow)
    {
        _follow.ChangeTarget(_possibleTargets[Random.Range(0,_possibleTargets.Length)].transform,gameObject.transform,1);
        print("Change Direction works");
    }

}
