using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Tilemaps;

public class PlayerMovementController : MonoBehaviour
{
    public float movementSpeed = 1f;
    Vector3 target = Vector3.zero;
    private void Awake()
    {
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit raycastHit;
            if (Physics.Raycast(ray, out raycastHit))
            {
                target = raycastHit.point;
                GetComponent<NavMeshAgent>().SetDestination(target);
            }
        }
       
    }
    #region fixed
    //void FixedUpdate()
    //{
    //    Vector2 currentPos = rbody.position;
    //    float horizontalInput = Input.GetAxis("Horizontal");
    //    float verticalInput = Input.GetAxis("Vertical");
    //    Vector2 inputVector = new Vector2(horizontalInput, verticalInput);
    //    inputVector = Vector2.ClampMagnitude(inputVector, 1);
    //    Vector2 movement = inputVector * movementSpeed;
    //    Vector2 newPos = currentPos + movement * Time.fixedDeltaTime;
    //    playerRenderer.SetDirection(movement);
    //    rbody.MovePosition(newPos);
    //}
    #endregion
}
