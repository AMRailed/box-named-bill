using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    [SerializeField] int spawnRate = 10;
    [SerializeField] GameObject[] enemies;
    [SerializeField] int[] numbers;
    public int Score = 0;
    public TMP_Text _textMeshPro;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2, spawnRate);
    }

    void Spawn()
    {
        int index = Random.Range(0, enemies.Length);
        Instantiate(enemies[index], transform);
        Score += numbers[index];
        _textMeshPro.text = "Score : " + Score;
    }
}
