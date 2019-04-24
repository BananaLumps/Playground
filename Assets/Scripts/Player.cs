using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public Animator anim;
    private Vector3 moveDirection = Vector3.zero;
    public Camera camdir;
    public GameObject invUI;
    private List<Item> playerInv;
    void Update()
    {
        if (Input.GetButtonDown("Inventory"))
        {
            switch (invUI.gameObject.activeSelf)
            {
                case true :
                    invUI.gameObject.SetActive(false);
                    break;
                case false:
                    invUI.gameObject.SetActive(true);
                    break;
            }
            
        }
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }

        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
        Quaternion charRotation = camdir.transform.rotation;
        charRotation.x = 0;
        charRotation.z = 0;
        transform.rotation = charRotation;
    }

    public void InvAdd(Item i)
    {
        playerInv.Add(i);
    }
}
