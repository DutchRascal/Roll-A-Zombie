using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int selectedZombiePosition;
    public GameObject selectedZombie;
    public List<GameObject> zombies;
    public Vector3 selectedSize;
    public Vector3 defaultSize;

    private void Start()
    {
        SelectZombie(zombies[0], 0);
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
        selectedZombie = newZombie;
        selectedZombie.transform.localScale = selectedSize;
        selectedZombiePosition = newPosition;
    }

    private void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            ShifLeft();
        }
        if (Input.GetKeyDown("right"))
        {
            ShiftRight();
        }
    }
}
