using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.Users;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed;

    private void Start()
    {
        PrintInstraction();
    }

    private void Update()
    {
        MovePlayer();
    }

    void PrintInstraction()
    {
        Debug.Log("Welcom to the game");
        Debug.Log ("It's show time");
    }

    void MovePlayer()
    {
        float moveX = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(moveX, 0, moveZ);
    }
}
