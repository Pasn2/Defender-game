using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    [SerializeField] SelectingSystem selecting;
    [SerializeField] bool IsDelay;
    public void SpawnObject(GameObject _objectToSpawn,Vector3 _localization,float _spawnDelay){
        if(!IsDelay){
            AudioManager.instance.PlaySound("BuildObject");
            Instantiate(_objectToSpawn,_localization,Quaternion.identity);
            IsDelay = true;
            StartCoroutine(Delay(_spawnDelay));
        }
    }
    
    IEnumerator Delay(float _delay){
        
        yield return new WaitForSeconds(_delay);
        IsDelay = false;
    }
}
