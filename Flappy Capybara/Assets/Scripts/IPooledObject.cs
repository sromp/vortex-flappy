using UnityEngine;

// NOTES:
// * This script is an interface for pooled objects.
// * Interfaces are scripts that allow you to specify types and functions that all derived objects have to implement.
// * All classes with this interface must incluse the OnObjectSpawn() function.

public interface IPooledObject
{
    void OnObjectSpawn();
}
