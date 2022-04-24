using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    public void TeleportTo()
    {
        this.transform.position = target.position;
    }

}
