using System;
using System.Collections;
using UnityEngine;

public class FillingLoadingBar : AtSceneSingleton<FillingLoadingBar>
{
    [SerializeField] private UnityEngine.UI.Image ProgressBar;
    public bool checkEnd = true;
    public IEnumerator Load(AsyncOperation asyncOperation)
    {
        ProgressBar.fillAmount = 0f; // 프로그레스 바가 시간에 따라 차오르게 하기 위한 설정
        var timer = 0.0f; // 로딩 시간 초기화
        // 비동기 오퍼레이터 처리
        asyncOperation.allowSceneActivation = false;// 비동기 씬 로드가 먼저 완성되더라도 씬을 바로 띄우지 않기 위한 처리.

        for (;!asyncOperation.isDone;)
        {
            yield return null;
            ProgressBar.fillAmount = 
                Mathf.Lerp(ProgressBar.fillAmount, 
                    (asyncOperation.progress < 0.9f) ? asyncOperation.progress : 1.0f, timer);
            timer = (asyncOperation.progress < 0.9f)
                ? ((ProgressBar.fillAmount>=asyncOperation.progress)? 0f:timer+Time.deltaTime)
                : timer+Time.deltaTime;
            if(Math.Abs(ProgressBar.fillAmount - 1.0f) > 0)asyncOperation.allowSceneActivation = true;
        }
        Debug.Log("Load is Done");
        checkEnd = false;
    }
}
