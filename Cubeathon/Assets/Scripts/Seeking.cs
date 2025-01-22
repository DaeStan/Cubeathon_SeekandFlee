using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeking : MonoBehaviour
{
    public Transform playerPosition;

    public float speed;
    public float detectionRange;

    public Renderer objectRenderer;

    void Update()
    {
        float currentPlayerPosition = Vector3.Distance(transform.position, playerPosition.position);

        if (currentPlayerPosition <= detectionRange)
        {
            transform.LookAt(playerPosition);

            objectRenderer.material.color = new Color(0.8f, 0.8f, 1f);

            transform.position = Vector3.MoveTowards(transform.position, playerPosition.position, speed * Time.deltaTime);
        }
    }
}
