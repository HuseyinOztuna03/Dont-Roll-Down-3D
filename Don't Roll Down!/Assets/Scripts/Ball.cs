using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Vector3 direction;
    public float speed;
    public FieldSpawner fieldSpawner;
    public static bool fall;
    public float inc_speed;
    void Start()
    {
        
        //PlayerPrefs.DeleteAll();
        direction = Vector3.forward;
    }
    void Update()
    {
        speed += inc_speed * Time.deltaTime;

        if (transform.position.y <= 0.74f)
        {
            fall = true;
        }

        if (fall == true)
        {
            return;
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
        }
    }
    private void FixedUpdate()
    {
        Vector3 move = direction * Time.deltaTime * speed;
        transform.position += move;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Field")
        {
            ScoreManager.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            fieldSpawner.spawn_field();
            StartCoroutine(wipedField(collision.gameObject));
        }
    }
    IEnumerator wipedField(GameObject wiped_field)
    {
        yield return new WaitForSeconds(3f);
        Destroy(wiped_field);
    }
}
