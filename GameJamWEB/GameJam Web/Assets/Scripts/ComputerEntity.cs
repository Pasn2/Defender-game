using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComputerEntity : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag=="Server"|| other.collider.tag == "AntyVirus")
        {
            gameObject.GetComponent<IEntity>().Use(other.gameObject);
        }
    }
}
