using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuroMovement : MonoBehaviour
{
    [SerializeField]Vector3 newPositionAtStart;
    [SerializeField]Vector3 saveTransform;
    [SerializeField]float speed;
    void Awake(){
        saveTransform = transform.position;
    }
    void Start()
    {
        transform.position = newPositionAtStart+transform.position;
    }
    public void Movement(){
        transform.position= Vector3.MoveTowards(transform.position,saveTransform,1*Time.deltaTime);
        print("Hola");
    }
}
