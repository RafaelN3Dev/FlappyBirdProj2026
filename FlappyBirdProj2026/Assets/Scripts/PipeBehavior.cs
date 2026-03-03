using System;
using UnityEngine;

public class PipeBehavior : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float InitialPos = 3f;
    [SerializeField] private float endPos = -5f;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        if (transform.position.x < endPos)
        {
            transform.position = new Vector3(InitialPos, transform.position.y, transform.position.z);
        }
    }
}
