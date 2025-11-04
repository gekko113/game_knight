using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallCollider : MonoBehaviour
{
    private PolygonCollider2D polygonCollider2D;

    private void Awake()
    {
        polygonCollider2D = GetComponent<PolygonCollider2D>();
    }

    public void EnableCollider()
    {
        polygonCollider2D.enabled = true;
    }

    public void DisableCollider()
    {
        polygonCollider2D.enabled = false;
    }

    private void Update()
    {
        
    }
}
