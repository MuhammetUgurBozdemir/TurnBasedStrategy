using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    private Vector3 targetPosition;
    [SerializeField] private Animator unitAnimator;

    private void Awake()
    {
        targetPosition = transform.position;
    }
    private void Update()
    {
        float stoppingDistane = 0.1f;
        if (Vector3.Distance(transform.position, targetPosition) > stoppingDistane)
        {
            Vector3 moveDirection = (targetPosition - transform.position).normalized;
            float moveSpeed = 4;
            transform.position += moveDirection * moveSpeed * Time.deltaTime;
            unitAnimator.SetBool("isWalking", true);
            transform.forward =Vector3.Lerp(transform.forward, moveDirection,15*Time.deltaTime);
        }
        else
        {
            unitAnimator.SetBool("isWalking", false);
        }
      
       
    }
    public void Move(Vector3 targetPosition)
    {
        this.targetPosition = targetPosition;

    }
}
