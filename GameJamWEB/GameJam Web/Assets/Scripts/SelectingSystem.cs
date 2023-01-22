using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class SelectingSystem : MonoBehaviour
{
    public SpawnableScriptableObject selectedOject;
    public Transform selectedServer;
    public bool isChooseServer{get {return selectedServer != null;}}
    [SerializeField] bool isSelected{get {return selectedOject != null;}}
    [SerializeField] Color hightLightColor;
    [SerializeField] BuildManager buildManager;
    [SerializeField] TMP_Text errorMassage;
    [SerializeField] float visibleTime;
    
    private void Update() {
        if(isSelected){
            RaycastHit2D raycastHit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()),Vector2.zero);
            if(raycastHit2D.collider != null && raycastHit2D.collider.tag == "Server"){
                selectedServer = raycastHit2D.collider.GetComponent<Transform>();
                raycastHit2D.collider.GetComponent<SpriteRenderer>().color = hightLightColor;
                if(GameManager.instance.playerInput.actions["Click"].triggered && isChooseServer){
                    Vector3 selectedVector3 = new Vector3(selectedServer.transform.position.x,selectedServer.transform.position.y,selectedServer.transform.position.z);
                    buildManager.SpawnObject(selectedOject.spawnGameObject,selectedVector3,selectedOject.spawnDelay);
                }
            }
            else{
                selectedServer = null;
            }
        }
    }
    void HighLightSpawnArea(){

    }
    public void SelectObject(SpawnableScriptableObject spawnobject){
        print("Selected!");
        selectedOject = spawnobject;
    }
}
