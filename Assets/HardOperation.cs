using System;
using System.Collections;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class HardOperation : MonoBehaviour
{
   public void StartLongOperation()
    {
        Debug.Log("Hard operation has started");

        for (int i = 0; i < 10000; i++)
        {
            Debug.Log("Created object # " + i);
        }

        Debug.Log("Hard operation is over");
    }


    public void StartCoroutineLongOperation()
    {
        StartCoroutine(DoLongOperation());
    }

    private IEnumerator DoLongOperation()
    {
        Debug.Log("Hard operation has started");

        yield return null;

        for (int i = 0; i < 10000; i++)
        {
            Debug.Log("Created object # " + i);
            yield return null;
        }

        Debug.Log("Hard operation is over");
    }

    public async void StartAsyncLongoperation()
    {

        Debug.Log("Hard operation has started");

        for (int i = 0; i < 10000; i++)
        {
            Debug.Log("Created object # " + i);
            await Task.Yield();
        }

        Debug.Log("Hard operation is over");
    }
    
     
    
}
