using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyControl : MonoBehaviour
{
	[SerializeField]
	private float speed = 3f;

	Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
		Move();

		Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));

		if (transform.position.y < min.y)
		{
			Destroy(gameObject);
		}
	}

	private void Move()
	{
		Vector2 position = rb.position;
		position.y = position.y + -speed * Time.fixedDeltaTime;
		rb.MovePosition(position);
	}
}
