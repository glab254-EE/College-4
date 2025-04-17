using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportArea : MonoBehaviour
{
    [SerializeField] private Transform TargetPositionPoint;
    [SerializeField] private string PlayerTag = "";
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(PlayerTag)){
            other.gameObject.transform.position = TargetPositionPoint.position;
        }
    }
}
