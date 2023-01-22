using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingLine : MonoBehaviour
{
    [SerializeField] LineRenderer link;
    [SerializeField] Vector3[] positionList = new Vector3[2];
    Transform startPosition;
    Transform webPosition;
    void Start()
    {
        link =GetComponent<LineRenderer>();
        startPosition = gameObject.transform;
        webPosition = GameObject.FindGameObjectWithTag("Web").transform;
        positionList[0]= startPosition.position;
        positionList[1] = webPosition.position;
        for (int i = 0; i < positionList.Length; i++)
        {
            Vector2 point = positionList[i];
            link.SetPosition(i,positionList[i]);
        }
        link.SetPositions(positionList);
    }
}
