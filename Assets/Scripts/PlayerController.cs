using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [SerializeField] private Animator animator;
    [SerializeField] private float timeToMove = 0.2f;
    private Vector2 lastDirection;
    private Vector2 velocity;
    private bool isMoving = false;
    private string lastButton = "Horizontal";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if(Mathf.Abs(direction.x) > Mathf.Abs(lastDirection.x))
        {
            lastButton = "Horizontal";
        }
        else if(Mathf.Abs(direction.y) > Mathf.Abs(lastDirection.y))
        {
            lastButton = "Vertical";
        }

        if(Input.GetAxisRaw(lastButton) == 0)
        {
            velocity = direction;
        }
        else
        {
            animator.SetBool("North", Input.GetAxisRaw(lastButton) > 0);
            if(lastButton == "Horizontal")
            {
                velocity = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
            }
            else if(lastButton == "Vertical")
            {
                velocity = new Vector2(0, Input.GetAxisRaw("Vertical"));
            }
        }

        RaycastHit2D hit = Physics2D.Raycast(transform.position, velocity, 1f);
        if(hit)
        {
            lastDirection = direction;
            return;
        }

        if(!isMoving && !hit && velocity.sqrMagnitude > 0)
        {
            StartCoroutine(Move());
        }

        lastDirection = direction;
    }

    private IEnumerator Move()
    {
        isMoving = true;
        animator.SetBool("Walking", true);

        Vector2 direction = new Vector2(velocity.x, velocity.y);
        Vector3 initial = transform.position;
        Vector3 final = initial;
        final.x += direction.x;
        final.y += direction.y;

        float elapsed = 0f;
        while(elapsed < timeToMove)
        {
            elapsed += Time.deltaTime;
            transform.position = Vector3.MoveTowards(initial, final, elapsed/timeToMove);
            yield return null;
        }
        transform.position = final;

        isMoving = false;
        animator.SetBool("Walking", false);
    }
}
