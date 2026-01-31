using UnityEngine;
using UnityEngine.Jobs;

public class PlayerMovement : MonoBehaviour
{
    public float WalkSpeed = 1f;
    public float SprintSpeed = 1.5f;

    public void Update()
    {
        float x, z;
        x = Input.GetAxisRaw("Horizontal");
        z = Input.GetAxisRaw("Vertical");

        float sprintMod = Input.GetKey(KeyCode.LeftShift) ? SprintSpeed : 1f;

        transform.position += (x * transform.right + z * transform.forward) * (Time.deltaTime * 7.5f * WalkSpeed * sprintMod);
    }
}
