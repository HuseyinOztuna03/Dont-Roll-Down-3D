using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldSpawner : MonoBehaviour
{
    public GameObject last_field;
    public GameObject first_field;

    void Start()
    {
        Object.Destroy(first_field, 5);
        for (int i = 0; i < 65; i++)
        {
            spawn_field();
            i++;
        }
    }

    public void spawn_field()
    {
        Vector3 _direction;

        if (Random.Range(0, 2) == 0)
        {
            _direction = Vector3.left;
        }
        else
        {
            _direction = Vector3.forward;
        }

        last_field = Instantiate(last_field, last_field.transform.position + _direction, last_field.transform.rotation);
    }
}
