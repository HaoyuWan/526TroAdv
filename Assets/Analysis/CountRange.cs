using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountRange : MonoBehaviour
{
    // Start is called before the first frame update
    private int bulletHitNum;
    private int bulletNoHitNum;
    public  string levelBulletHit;
    public  string levelBulletNoHit;
    void Start()
    {
         bulletHitNum = 0;
         bulletNoHitNum=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void shoot1(){
        bulletHitNum ++;
        Debug.Log("Bullet hit: " + bulletHitNum );
    }
    public void ReduceShootWhenHit(){
        bulletNoHitNum--;
    }
    public void shoot2(){
      
        bulletNoHitNum ++;
        Debug.Log("Bullet no hit: " + bulletNoHitNum );
    }

     void OnDestroy(){
         bulletHitNum  =  bulletHitNum  + PlayerPrefs.GetInt(levelBulletHit, 0);
         bulletNoHitNum  =  bulletNoHitNum  + PlayerPrefs.GetInt(levelBulletNoHit, 0);
        Debug.Log("Destryoyed Bullet hit: " + bulletHitNum);
        Debug.Log("Destryoyed Bullet no hit: " + bulletNoHitNum);
        PlayerPrefs.SetInt(levelBulletHit, bulletHitNum);
        PlayerPrefs.SetInt(levelBulletNoHit, bulletNoHitNum);
    }
}
