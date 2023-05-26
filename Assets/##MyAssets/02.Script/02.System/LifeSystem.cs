using UnityEngine;

public class LifeSystem : AtSceneSingleton<LifeSystem>
{
   // Checking Life for Enemy
   public static bool CheckLife(GameObject obj, int life)
   {
      if (life > 0) return true;
      PoolingSystem.Instance.ReturnObject(obj.name, obj);
      return false;
   }

}

