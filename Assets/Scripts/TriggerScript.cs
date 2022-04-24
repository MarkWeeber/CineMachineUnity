using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TriggerScript : MonoBehaviour
{
    [SerializeField]
    private LayerMask targetMask = 0;
    [SerializeField]
    private PlayableDirector timeline;
    private bool activated = false;
    void OnTriggerEnter(Collider other)
    {
        if (((targetMask.value & (1 << other.transform.gameObject.layer)) > 0) && !activated)
        {
            activated = true;
            if(timeline != null)
            {
                timeline.Play();
            }
        }                 
    }
}
