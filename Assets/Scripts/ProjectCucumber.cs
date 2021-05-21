using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectCucumber : MonoBehaviour
{
    [SerializeField] int damage = 100;
    [SerializeField] float moveSpeed = 1f;
    [SerializeField] float rotationSpeed = 1f;

    public int GetDamage() { return damage; }
    void Update()
    {
        /* transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
         transform.Rotate(0, 0, rotationSpeed * Time.deltaTime, Space.Self);*/
        transform.Rotate(Vector3.forward * Time.deltaTime);
    }
}
