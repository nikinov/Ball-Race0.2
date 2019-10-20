using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    GameObject BeachPinkSkin;
    GameObject BeachBlueSkin;
    GameObject BeachRedSkin;

    Rigidbody PS;
    Rigidbody BS;
    Rigidbody RS;

    public int BeachSkin;

    private void Awake()
    {
        BeachPinkSkin = GameObject.FindGameObjectWithTag("BeachPinkSkin");
        BeachBlueSkin = GameObject.FindGameObjectWithTag("BeachBlueSkin");
        BeachRedSkin = GameObject.FindGameObjectWithTag("BeachRedSkin");
        PS = BeachPinkSkin.GetComponent<Rigidbody>();
        BS = BeachPinkSkin.GetComponent<Rigidbody>();
        RS = BeachPinkSkin.GetComponent<Rigidbody>();
        LoadData();
    }
    public void ToPlay ()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }
    private void Update()
    {
        if (BeachSkin == 0)
        {
            BeachPinkSkin.SetActive(true);
            SaveData();
        }
        else
        {
            BeachPinkSkin.SetActive(false);
        }
        if (BeachSkin == 1)
        {
            BeachBlueSkin.SetActive(true);
            SaveData();
        }
        else
        {
            BeachBlueSkin.SetActive(false);
        }
        if (BeachSkin == 2)
        {
            BeachRedSkin.SetActive(true);
            SaveData();
        }
        else
        {
            BeachRedSkin.SetActive(false);
        }
    }
    public void SaveData ()
    {
        SaveGame.saveData(this);
    }
    public void LoadData ()
    {
        GameData data = SaveGame.LoadData();

        BeachSkin = data.Pink;
    }
    public void Pink ()
    {
        BeachSkin = 0;
    }
    public void Blue()
    {
        BeachSkin = 1;
    }
    public void Red()
    {
        BeachSkin = 2;
    }
}
