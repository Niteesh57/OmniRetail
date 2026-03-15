using UnityEngine;

public class FabricPhysics : MonoBehaviour
{
    public Cloth clothComponent;

    void Start()
    {
        clothComponent = GetComponent<Cloth>();
        clothComponent.enabled = true;
    }

    void Update()
    {
        // Simulate fabric physics
        clothComponent.Simulate(Time.deltaTime);
    }
}