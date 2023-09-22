using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class clickScript : MonoBehaviour
{
    public TextMeshProUGUI clickText;
    private int clickCount = 0;

    public GameObject fruitsPrefab;
    public Transform fruitsSpawn;

    void Update()
    { 
        clickText.text = "Feed Pac-Man: ";
    }

    public void click()
    {
        clickCount++;
        spawnFruits();
    }

    void spawnFruits()
    {
        Vector3 spawnPosition = fruitsSpawn.position;
        GameObject fruits = Instantiate(fruitsPrefab, spawnPosition, Quaternion.identity);
        fruits.GetComponent<fruitMovement>().speed = 0.5f;
    }
}
