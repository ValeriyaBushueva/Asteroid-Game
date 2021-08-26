using UnityEngine;

public class MouseObjectMover : MonoBehaviour
{
    private Camera camera;

    private void Start() => camera = Camera.main;

    private void Update() => transform.position = camera.ScreenToWorldPoint(Input.mousePosition);
}