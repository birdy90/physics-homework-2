using UnityEngine;

public class CannonTrigger : MonoBehaviour
{
    public Cannon Cannon;

    private void OnTriggerEnter(Collider other)
    {
        Cannon.Pull();
    }
}
