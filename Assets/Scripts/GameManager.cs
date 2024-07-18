using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public Transform spawnPosition;

    private void Awake()
    {
        instance = this;
    }
}
