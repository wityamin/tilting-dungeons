using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeFloorDetail : MonoBehaviour
{
    public GameObject detail;
    public float radius;
    void Awake()
    {
        float defaultHeight = detail.transform.position.y;
        detail.transform.position = new Vector3(Random.Range(-radius, radius), defaultHeight, Random.Range(-radius, radius));
        detail.transform.rotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
    }
}
