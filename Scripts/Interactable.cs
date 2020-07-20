using UnityEngine;
using UnityEngine.AI;

public class Interactable : MonoBehaviour {

    public float Radius = 3f;
    

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, Radius);
    }
}
