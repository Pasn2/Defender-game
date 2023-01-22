using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Spawn", menuName = "SpawnableObject/new Spawn Object")]
public class SpawnableScriptableObject : ScriptableObject
{
    public Image objectImage;
    public string spawnName;
    public string spawnDescryption;
    public int costInCapacity;
    public int costInCurrency;
    public GameObject spawnGameObject;
    public float spawnDelay;

}
