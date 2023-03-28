using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private BallsState ballsState;
    [SerializeField] private LayerMask ballLayer;
    
    private void OnTriggerEnter(Collider other)
    {
        if(ballLayer == (ballLayer | (1 << other.gameObject.layer)))
        {
            ballsState.RemoveBall(other.gameObject);
        }
    }
}
