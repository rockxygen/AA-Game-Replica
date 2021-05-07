using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinController : MonoBehaviour
{
    public float pinSpeed = 20f;
    public Rigidbody2D RB;

    public bool isPinned = false;

    private void Update()
    {
        if (!isPinned)
        {
            RB.MovePosition(RB.position + Vector2.up * pinSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "MCircle")
        {
            transform.SetParent(collision.transform);
            collision.GetComponent<CircleController>().rotateSpeed += 5f;
            Score.PinScore++;
            isPinned = true;
        }
        else if(collision.tag == "CCircle")
        {
            FindObjectOfType<GameMechanics>().LostGame();
        }
    }
}
