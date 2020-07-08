using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
  private Animator anim;
  public GameObject button;

  private void Awake()
  {
    anim = GetComponent<Animator>();
  }

  public void Replay()
  {
    Time.timeScale = 1;
    UnityEngine.SceneManagement.SceneManager.LoadScene(2);
  }

  //点击 pause 按钮
  public void Pause()
  {
    //1.播放pause动画
    anim.SetBool("isPause", true);
    button.SetActive(false);

    if (GameManager._instance.birds.Count > 0)
    {
      if (GameManager._instance.birds[0].isReleased == false)//没有飞出
      {
        GameManager._instance.birds[0].canMove = false;
      }
    }
  }

  //点击了继续按钮
  public void Resume()
  {
    //1.播放resume动画
    Time.timeScale = 1;
    anim.SetBool("isPause", false);
    
    if (GameManager._instance.birds.Count > 0)
    {
      if (GameManager._instance.birds[0].isReleased == false)//没有飞出
      {
        GameManager._instance.birds[0].canMove = true;
      }
    }
  }
  
  public void Home()
  {
    UnityEngine.SceneManagement.SceneManager.LoadScene(1);
  }

  //pause动画播放完调用
  public void PauseAnimEnd()
  {
    Time.timeScale = 0;
  }
  
  //resume动画播放完调用
  public void ResumeAnimEnd()
  {
    
    button.SetActive(true);
  }
}
