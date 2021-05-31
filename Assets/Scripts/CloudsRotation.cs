using UnityEngine;

public class CloudsRotation : MonoBehaviour
{
    private void Update()
    {
        Clouds();
    }

    public void Clouds()
    {
        transform.Rotate(0, 0.2f, 0);
    }
}
