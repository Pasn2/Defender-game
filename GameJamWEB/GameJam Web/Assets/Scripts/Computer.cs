using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Computer : MonoBehaviour
{
    [SerializeField] float infectionRate;
    [SerializeField] Slider infectionSlider;
    [SerializeField] float maxInfection;
    float currentInfection;
    
    [SerializeField] Color curedColor;
    SpriteRenderer sprite;

    void Start()
    {
        currentInfection = maxInfection;
        RemoveInfection(30);
    }
    void Update()
    {
        currentInfection += 0.01f;
    }
    public void AddInfection(float _addedInfection){
        currentInfection += _addedInfection;
        if(currentInfection > maxInfection){
            currentInfection = maxInfection;
        }

    }
    public void RemoveInfection(float _removeInfection){
        currentInfection -= _removeInfection;
        print("KDAWD");
        if(currentInfection <= 0){
            Cure();
        }
    }
    void Cure(){
        sprite.material.color = curedColor;
    }
    private void OnTriggerEnter2D(Collider2D other) {
        print("d");
        print(other.tag);
        if(other.tag == "AntyVirus"){
            print("x");
            RemoveInfection(30);
            other.GetComponent<AntyVirusCell>().Dead();
        }
    }
}
