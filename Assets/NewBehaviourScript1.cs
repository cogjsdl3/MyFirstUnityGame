using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player
{
    private string name;
    private int level = 1;

    public Player(string name) {
        this.name = name;

    }
    public void GetInfo() {
        Debug.Log("이름 : " + name);
        Debug.Log("레벨 : " + level);
    }
    public void LevelUp()
    {
        this.level++;
            Debug.Log("레벨 업~!");

    }
}
public class NewBehaviourScript1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player myplayer = new Player("홍길동");
        myplayer.GetInfo();
        myplayer.LevelUp();
        myplayer.GetInfo();

    }


}
