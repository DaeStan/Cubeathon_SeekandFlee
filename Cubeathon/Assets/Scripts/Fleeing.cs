using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fleeing : MonoBehaviour
{
    public Transform playerPosition;

    public float speed;
    public float detectionRange;

    void Update()
    {
        float currentPlayerPosition = Vector3.Distance(transform.position, playerPosition.position);

        if (currentPlayerPosition <= detectionRange)
        {
            Vector3 oppositePlayerDirection = transform.position - playerPosition.position;
            Vector3 oppositePlayerPosition = transform.position + oppositePlayerDirection;

            transform.LookAt(oppositePlayerPosition);

            transform.position += oppositePlayerDirection.normalized * speed * Time.deltaTime;
        }
    }
}
