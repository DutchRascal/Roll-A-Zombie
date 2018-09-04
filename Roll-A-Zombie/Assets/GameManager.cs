using System;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int selectedZombiePosition;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;
    public Text text;
    private int score;


    private void Start()
    {
        SelectZombie(zombies[0], 0);
        text.text = "Score: " + score;
    }
    void ShifLeft()
    {
        if (selectedZombiePosition == 0)
        {
            SelectZombie(zombies[3], 3);
        }
        else
        {
            SelectZombie(zombies[selectedZombiePosition - 1], selectedZombiePosition - 1);
        }
    }

    void ShiftRight()
    {
        if (selectedZombiePosition == 3)
        {
            SelectZombie(zombies[0], 0);
        }
        else
        {
            SelectZombie(zombies[selectedZombiePosition + 1], selectedZombiePosition + 1);
        }
    }

    void SelectZombie(GameObject newZombie, int newPosition)
    {
        selectedZombie.transform.localScale = defaultSize;
        selectedZombie = newZombie;
        selectedZombie.transform.localScale = selectedSize;
        selectedZombiePosition = newPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            ShifLeft();
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            ShiftRight();
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            PushUp();
        }
    }

    private void PushUp()
    {
        Rigidbody rb = selectedZombie.GetComponent<Rigidbody>();
        rb.AddForce(0, 0, 10, ForceMode.Impulse);
    }

    public void AddScore()
    {
        score += 1;
        text.text = "Score: " + score;
    }
}
