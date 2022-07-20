using UnityEngine;

public class Cannon : MonoBehaviour
{
    private bool _isPulled;

    public Rigidbody Body;

    public void Pull()
    {
        Body.AddForce(transform.up * 20000f);
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        var trans = transform;
        var pos = trans.position;
        Gizmos.DrawLine(pos, pos + trans.up);
    }
}
