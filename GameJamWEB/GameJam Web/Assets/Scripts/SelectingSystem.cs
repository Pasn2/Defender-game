using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class SelectingSystem : MonoBehaviour
{
    [SerializeField] SpawnableScriptableObject selectedOject;

    [SerializeField] bool isSelected{get {return selectedOject != null;}}
    [SerializeField] Color hightLightColor;
    [SerializeField] BuildManager buildManager;
    [SerializeField] TMP_Text errorMassage;
    [SerializeField] float visibleTime;
    private void Start() {
        
    }
    private void Update() {
        if(isSelected && GameManager.instance.playerInput.actions["Click"].triggered){
            RaycastHit2D raycastHit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()),Vector2.zero);
            if(raycastHit2D.collider.GetComponent<ISpawnable>() != null){
                Transform selectedServer = raycastHit2D.collider.transform;
                Vector3 selectedVector3 = new Vector3(selectedServer.transform.position.x,selectedServer.transform.position.y,selectedServer.transform.position.z);
                buildManager.SpawnObject(selectedOject.spawnGameObject,selectedVector3,selectedOject.spawnDelay);
            }
        }
    }
    public void SelectObject(SpawnableScriptableObject spawnobject){
        print("Selected!");
        selectedOject = spawnobject;
    }
}
