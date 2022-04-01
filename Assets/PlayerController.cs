using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private float timeToMove = 0.2f;
    private Vector2 lastDirection;
    private Vector2 velocity;
    private bool isMoving = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        velocity = Vector2.zero;
        if(Mathf.Abs(direction.x) > Mathf.Abs(lastDirection.x))
        {
            velocity.x = direction.x;
            velocity.y = 0;
        }
        if(Mathf.Abs(direction.y) > Mathf.Abs(lastDirection.y))
        {
            velocity.y = direction.y;
            velocity.x = 0;
        }
        if(!isMoving && velocity.sqrMagnitude > 0)
        {
            StartCoroutine("Move");
        }

        lastDirection = direction;
    }

    private IEnumerator Move()
    {
        isMoving = true;

        Vector2 direction = new Vector2(velocity.x, velocity.y);
        Vector3 initial = transform.position;
        Vector3 final = initial;
        final.x += direction.x;
        final.y += direction.y;
        float elapsed = 0f;
        while(elapsed < timeToMove)
        {
            elapsed += Time.deltaTime;
            Vector3.MoveTowards(initial, final, elapsed/timeToMove);
            yield return null;
        }
        transform.position = final;

        isMoving = false;
    }
}
