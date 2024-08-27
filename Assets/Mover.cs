using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Users;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private void Start()
    {

    }

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(moveX, 0, moveZ);
    }
}
