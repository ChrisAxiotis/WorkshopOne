using UnityEngine;

public class DestroyTrigger : MonoBehaviour
{

    public float TimeToKill = 8;

    private void Start()
    {
        Destroy(gameObject, TimeToKill);
    }
}
