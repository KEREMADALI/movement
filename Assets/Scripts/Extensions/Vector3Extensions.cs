using UnityEngine;
using System.Collections;

public static class Vector3Extensions
{
    public static float DistanceTo(this Vector3 original, Vector3 target) 
    {
        if (original == null || target == null) 
        {
            throw new System.Exception("Vectors can not be null in Vector3.DistanceTo() method!");
        }

        return Vector3.Distance(original, target);
    }
     
    public static Vector3 With(this Vector3 original, float? x = null, float? y = null, float? z = null) 
    {
        var newX = x.HasValue ? (float)x : original.x;
        var newY = y.HasValue ? (float)y : original.y;
        var newZ = z.HasValue ? (float)z : original.z;

        return new Vector3(newX, newY, newZ);
    }
}
