using UnityEngine;

namespace ThrashJT.Lab3
{
    public interface IPrefabFactory
    {

        GameObject CreatePrefab(Vector3 position);
    }
}

