using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardWalking : MonoBehaviour
{
    public GameObject character;
    public float walkingSpeed = 2.0f; 
    public float destroyTime = 10.0f;

    private void FixedUpdate()
    {
        MoveCharacter();
    }

    private void MoveCharacter()
    {
        Rigidbody characterRigidbody = character.GetComponent<Rigidbody>();

        characterRigidbody.AddForce(transform.forward * walkingSpeed, ForceMode.Force);
        Destroy(character, destroyTime);
    }
}
