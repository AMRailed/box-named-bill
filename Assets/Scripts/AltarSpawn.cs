using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AltarSpawn : MonoBehaviour
{

    [SerializeField] SpawnManager spawnManager;
    [SerializeField] GameObject Boss;
    private bool BossSpawned = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "playerchar" && !BossSpawned)
        {
            BossSpawned = true;
            Instantiate(Boss, transform.position + new Vector3(0, 20, 0), transform.rotation);
            spawnManager.Score += 20;
            spawnManager._textMeshPro.text = "Score : " + spawnManager.Score;
        }
    }
}
