using UnityEngine;

// A glowing pillar that floats above the next place to go.
public class TargetMarker : MonoBehaviour
{
    public float height = 4f;       // how high above the target
    public float spinSpeed = 90f;   // degrees per second
    public float bobAmount = 0.3f;  // up/down movement
    public float bobSpeed = 2f;

    Vector3 basePosition;

    void Awake()
    {
        basePosition = transform.position;
    }

    // Move above a target and show the marker.
    public void MoveTo(Transform target)
    {
        basePosition = target.position + Vector3.up * height;
        transform.position = basePosition;
        gameObject.SetActive(true);
    }

    // Hide the marker (game finished).
    public void Hide()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        transform.Rotate(0f, spinSpeed * Time.deltaTime, 0f);
        transform.position = basePosition + Vector3.up * Mathf.Sin(Time.time * bobSpeed) * bobAmount;
    }
}
