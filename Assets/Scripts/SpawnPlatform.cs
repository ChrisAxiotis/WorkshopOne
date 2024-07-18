using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{

    public GameObject platform;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Hello Player");
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(platform, GameManager.instance.spawnPosition.position, Quaternion.identity);
    }
}
