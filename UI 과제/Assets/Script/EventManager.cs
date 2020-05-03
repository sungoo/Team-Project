using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    private bool canMoving = true;
    private bool canJumping = true;

    public GameObject player;
    public GameObject face;

    public float speed = 0.05f;

    Vector3 vector3;

    public int walkCount = 20;
    private int currWalkCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoveCoroutine()
    {
        while (currWalkCount < walkCount)
        {
            player.transform.Translate(vector3.x * speed, vector3.y * speed, vector3.z * speed);

            currWalkCount++;
            yield return new WaitForSeconds(0.02f);
        }
        currWalkCount = 0;

        canMoving = true;
    }

    IEnumerator JumpCoroutine()
    {
        while (currWalkCount < walkCount)
        {
            player.transform.Translate(vector3.x * speed, vector3.y * (speed - ((float)currWalkCount / 200)), vector3.z * speed);

            currWalkCount++;
            yield return new WaitForSeconds(0.02f);
        }
        currWalkCount = 0;

        canJumping = true;
    }

    public void Return()
    {
        player.transform.position = new Vector3(0, 2, 0);
    }

    public void Jump()
    {
        if (canJumping)
        {
            vector3 = new Vector3(0, 5, 0);
            canJumping = false;
            StartCoroutine(JumpCoroutine());
        }
    }

    public void moveFront()
    {
        if (canMoving)
        {
            vector3 = new Vector3(0, 0, 1);
            canMoving = false;
            StartCoroutine(MoveCoroutine());
        }
    }

    public void moveBack()
    {
        if (canMoving)
        {
            vector3 = new Vector3(0, 0, -1);
            canMoving = false;
            StartCoroutine(MoveCoroutine());
        }
    }

    public void moveLeft()
    {
        if (canMoving)
        {
            vector3 = new Vector3(-1, 0, 0);
            canMoving = false;
            StartCoroutine(MoveCoroutine());
        }
    }

    public void moveRight()
    {
        if (canMoving)
        {
            vector3 = new Vector3(1, 0, 0);
            canMoving = false;
            StartCoroutine(MoveCoroutine());
        }
    }

    public void okayButton()
    {
        Destroy(face.gameObject, 0);
    }
}
