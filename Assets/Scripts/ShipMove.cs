using UnityEngine;

public class ShipMove : MonoBehaviour
{
	Rigidbody2D rb;
	Vector2 mousePos;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
	}

	/*public void Move(InputAction.CallbackContext context)
	{
		mousePos = context.ReadValue<Vector2>();
	}

	private void FixedUpdate()
	{
		if (mousePos.magnitude > 0f)
		{
			ShipMovement();
		}
	}*/

	public void ShipMovement(Vector2 position)
	{
		//Vector3 screenPos = new Vector3(mousePos.x, mousePos.y, 10f);
		//Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos);
		rb.MovePosition(position);
	}
}
