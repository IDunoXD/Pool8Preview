using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallsState : MonoBehaviour
{
    [SerializeField] private float minBallStopVelocity;
    private List<Rigidbody> _balls;

    void Start()
    {
        _balls = new List<Rigidbody>();
        foreach(Transform ball in transform)
        {
            _balls.Add(ball.GetComponent<Rigidbody>());
        }
    }

    public void RemoveBall(GameObject ball)
    {
        _balls.Remove(ball.GetComponent<Rigidbody>());
        Destroy(ball);
    }

    public bool AreAllBallsStopped(){
        foreach(var ball in _balls)
        {
            if(ball.velocity.magnitude > minBallStopVelocity)
            {
                return false;
            }
        }
        return true;
    }
}
