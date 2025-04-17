using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class ButtonDoorHandler : MonoBehaviour
{
    [SerializeField] private Transform DoorReference;
    [SerializeField] private Transform TargetPositionPoint;
    [SerializeField] private string PlayerTag = "";
    [SerializeField] private float OpeningTime = 1f;
    bool activated = false;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(PlayerTag) && !activated){
            activated = true;
            DoorReference.DOMove(TargetPositionPoint.position,OpeningTime);
        }
    }
}
