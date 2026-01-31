using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float WalkSpeed = 1;
    public float SprintSpeed = 1;

    public void Update()
    {
        float x, z;
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        SprintSpeed = Input.GetKey(KeyCode.LeftShift) ? 1.5f : 1f;

        var parent = transform.parent.transform;
        parent.position = new Vector3(parent.position.x + x * (Time.deltaTime * 100 * WalkSpeed * SprintSpeed), parent.position.y,
            parent.position.z + z * (Time.deltaTime * 100 * WalkSpeed * SprintSpeed));
    }
}
