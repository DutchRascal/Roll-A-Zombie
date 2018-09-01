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

    void SelectZombie(GameObject newZombie, int newPosition)
    {
        selectedZombie = newZombie;
        selectedZombie.transform.localScale = selectedSize;
    }
}
