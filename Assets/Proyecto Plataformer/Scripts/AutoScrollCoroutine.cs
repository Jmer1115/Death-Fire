using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoScrollCoroutine : MonoBehaviour
{
    public float scrollSpeed = 2f;
    public Vector2 directionBounds = new Vector2(1, 1);
    public float resetPosition = -10f;
    public float startDelay = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;

        StartCoroutine(StartDelay());
    }

    IEnumerator StartDelay()
    {
        yield return new WaitForSeconds(startDelay);

        StartCoroutine(MoveLevelBounds());
    }

    IEnumerator MoveLevelBounds()
    {
        
        while (true)
        {
            transform.position += (Vector3)directionBounds * scrollSpeed * Time.deltaTime;

            yield return null;
        }
    }
}
