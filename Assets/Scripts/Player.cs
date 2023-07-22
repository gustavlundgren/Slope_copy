using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 7.0f;
    [SerializeField] private GameInput gameInput;


    private void Update()
    {
        Vector2 inputVector = gameInput.GetMovementVectorNormalized();
        Vector3 moveDir = new Vector3(inputVector.x, 0f, 0f);

        float moveDistance = moveSpeed * Time.deltaTime;
        
        // Collisions
        // float playerRadius = .7f;
        // float playerHeight = 2f;
        // bool canMove = !Physics.CapsuleCast(transform.position, transform.position + Vector3.up * playerHeight, playerRadius, moveDir, moveDistance);


        transform.position += moveDir * moveDistance;
    }
}
