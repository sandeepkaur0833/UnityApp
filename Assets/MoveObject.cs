using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveObject : MonoBehaviour
{
    bool isPressed = false;
    public Button myButton;
    public GameObject Player;
    public float Force;
    public float moveDistance = 0.3f;
    public float moveDistance1 = 0.1f;
    public float rotationAngle = 30f;
    public float rotationSpeed = 100f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 currentPosition = Player.transform.position;
            Vector3 newPosition = currentPosition + new Vector3(-moveDistance1, 0f, 0f);
            Player.transform.position = newPosition;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 currentPosition = Player.transform.position;
            Vector3 newPosition = currentPosition + new Vector3(+moveDistance1, 0f, 0f);
            Player.transform.position = newPosition;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 currentPosition = Player.transform.position;
            Vector3 newPosition = currentPosition + new Vector3(0f, moveDistance1, 0f);
            Player.transform.position = newPosition;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 currentPosition = Player.transform.position;
            Vector3 newPosition = currentPosition - new Vector3(0f, moveDistance1, 0f);
            Player.transform.position = newPosition;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            float rotationAngle = rotationSpeed * Time.deltaTime;
            Player.transform.Rotate(Vector3.forward, rotationAngle);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            float rotationAngle = rotationSpeed * Time.deltaTime;
            Player.transform.Rotate(Vector3.forward, -rotationAngle);
        }
    }


    public void left()
    {
        Vector3 currentPosition = Player.transform.position;
        Vector3 newPosition = currentPosition + new Vector3(-moveDistance, 0f, 0f);
        Player.transform.position = newPosition;
    }

    public void right()
    {
        Vector3 currentPosition = Player.transform.position;
        Vector3 newPosition = currentPosition + new Vector3(+moveDistance, 0f, 0f);
        Player.transform.position = newPosition;
    }


    public void up()
    {
        Vector3 currentPosition = Player.transform.position;
        Vector3 newPosition = currentPosition + new Vector3(0f, moveDistance, 0f);
        Player.transform.position = newPosition;
    }


    public void down()
    {
        Vector3 currentPosition = Player.transform.position;
        Vector3 newPosition = currentPosition + new Vector3(0f, -moveDistance, 0f);
        Player.transform.position = newPosition;
    }


    public void rotateClockWise()
    {
        Player.transform.Rotate(Vector3.forward, rotationAngle);
    }

    public void rotateAntiClockWise()
    {
        Player.transform.Rotate(Vector3.forward, -rotationAngle);
    }


    public void scaleUp()
    {
        Player.transform.Translate(Force * Time.deltaTime, 0, 0);
    }

 
}