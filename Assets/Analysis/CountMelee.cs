using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountMelee : MonoBehaviour
{
    // Start is called before the first frame update
      private int meleeHitnum;
    private int meleeNoHitnum;
    public string levelMeleeHit;
   public  string levelMeleeNoHit;
   
    void Start()
    {
         meleeHitnum = 0;
         meleeNoHitnum=0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void attack1(){
        meleeHitnum ++;
        Debug.Log("Melee hit: " + meleeHitnum );
    }
    public void ReduceWhenHit(){
        meleeNoHitnum--;
    }
    public void attack2(){
      
        meleeNoHitnum ++;
        Debug.Log("Melee no hit: " + meleeNoHitnum );
    }

     void OnDestroy(){
       meleeHitnum =  meleeHitnum  + PlayerPrefs.GetInt(levelMeleeHit, 0);
         meleeNoHitnum  =  meleeNoHitnum + PlayerPrefs.GetInt(levelMeleeNoHit, 0);
        Debug.Log("Destryoyed Melee hit: " + meleeHitnum);
        Debug.Log("Destryoyed Melee no hit: " + meleeNoHitnum);
        PlayerPrefs.SetInt(levelMeleeHit, meleeHitnum);
        PlayerPrefs.SetInt(levelMeleeNoHit, meleeNoHitnum );
    }
}
