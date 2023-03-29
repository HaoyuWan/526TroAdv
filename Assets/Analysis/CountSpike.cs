using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountSpike : MonoBehaviour
{
    // Start is called before the first frame update
       private int spikeNum=0;
       private int acidNum=0;
       public string levelSpike;
       public string levelAcid;
      public string name;
 private int x=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
      public void attack(string n){
      
      if(n=="Spike"){
            spikeNum ++;
        Debug.Log(n+" hit: " + spikeNum );
        x= 1 + PlayerPrefs.GetInt(levelSpike, 0);
        PlayerPrefs.SetInt(levelSpike, x);
    }
    if(n== "Acid"){
         acidNum++;
         Debug.Log(n+" hit: " + acidNum );
         x= 1 + PlayerPrefs.GetInt(levelAcid, 0);
        PlayerPrefs.SetInt(levelAcid, x);
      }
   }
      
           
        

        
    
    // public void OnHitDamageable(Damager origin, Damageable damageable){
    //     attack();
    // }
//      void OnDestroy(){
//         // damageNum = damageNum + PlayerPrefs.GetInt(levelDamage, 0);
//         Debug.Log("Destryoyed Spike hit: " + spikeNum);
       
//         // PlayerPrefs.SetInt(levelDamag
// }
}
