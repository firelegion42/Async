using UnityEngine;

public class HardOperation : MonoBehaviour
{
   public void StartLongOperation()
    {
        Debug.Log("Hard operation has started");

        for (int i = 0; i < 10000; i++)
        {
            Debug.Log("Created object # {i}");
        }

        Debug.Log("Hard operation is over");
    }
}
