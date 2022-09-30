using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScript : MonoBehaviour
{
    float timer = 18f;
    
    //sprite for changing colors
    SpriteRenderer sprite;

    //color list
    private List<Color> colorArray;

    //lights
    public GameObject redNS;
    public GameObject yellowNS;
    public GameObject greenNS;
    public GameObject redEW;
    public GameObject yellowEW;
    public GameObject greenEW;

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        colorArray = new List<Color>();

        //red on 0
        colorArray.Add(Color.red);
        //red off 1
        colorArray.Add(new Color(0.188f, 0, 0, 1));
        //yellow on 2
        colorArray.Add(Color.yellow);
        //yellow off 3
        colorArray.Add(new Color(0.188f, 0.167f, 0, 1));
        //green on 4
        colorArray.Add(Color.green);
        //green off 5
        colorArray.Add(new Color(0, 0.132f, 0, 1));    
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if(timer > 13){
           GreenLightNS();
           RedLightEW();
        }
        if(timer <= 13 && timer > 10){
            YellowLightNS();
            RedLightEW();
        }
        if(timer <= 10 && timer > 9){
            RedLightNS();
            RedLightEW();
        }
        if(timer <= 9 && timer > 4){
            GreenLightEW();
            RedLightNS();
        }
        if(timer <= 4 && timer > 1){
            YellowLightEW();
            RedLightNS();
        }
        if(timer <= 1 && timer > 0){
            RedLightEW();
            RedLightNS();
        }
        if(timer <= 0){
            timer = 28f;
        }       
    }

    void RedLightNS(){
        sprite = redNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[0];
        sprite = yellowNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[3];
        sprite = greenNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[5];
    }
    void YellowLightNS(){
        sprite = redNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[1];
        sprite = yellowNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[2];
        sprite = greenNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[5];
    }
    void GreenLightNS(){
        sprite = redNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[1];
        sprite = yellowNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[3];
        sprite = greenNS.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[4];
    }
    void RedLightEW(){
        sprite = redEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[0];
        sprite = yellowEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[3];
        sprite = greenEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[5];
    }
    void YellowLightEW(){
        sprite = redEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[1];
        sprite = yellowEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[2];
        sprite = greenEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[5];
    }
    void GreenLightEW(){
        sprite = redEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[1];
        sprite = yellowEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[3];
        sprite = greenEW.GetComponent<SpriteRenderer>();
        sprite.color = colorArray[4];
    }
}
