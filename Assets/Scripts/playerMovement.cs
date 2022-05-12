using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private CharacterController characterController;

    //[SerializeField]
    private float moveSpeed = 1000;

    private void Awake()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        var movement = new Vector3(horizontal/2, 0, vertical);

        characterController.SimpleMove(movement * Time.deltaTime * moveSpeed);
    }
}
