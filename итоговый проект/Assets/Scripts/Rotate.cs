using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] public float speed;
    [SerializeField] public Vector3 target;

    private void Update()
    {
        transform.localRotation = Quaternion.RotateTowards(transform.localRotation, Quaternion.Euler(target), speed * Time.deltaTime);
    }
}
