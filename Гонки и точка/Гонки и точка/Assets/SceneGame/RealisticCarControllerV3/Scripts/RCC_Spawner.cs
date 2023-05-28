//----------------------------------------------
//            Realistic Car Controller
//
// Copyright © 2014 - 2020 BoneCracker Games
// http://www.bonecrackergames.com
// Buğra Özdoğanlar
//
//----------------------------------------------

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RCC_Spawner : MonoBehaviour {

	[SerializeField] private int _selectedIndex;

	// Use this for initialization
	void Start () 
    {
        int selectedIndex = PlayerPrefs.GetInt("SelectedRCCVehicle", 0);
        switch (StartGame.NumberSelectedCar)
        {
            case 0://skala
            case 1://skala
                _selectedIndex = 3;
                break;
            case 2://e36
            case 3://e36
                _selectedIndex = 1;
                break;
            case 4://e46
            case 5://e46
                _selectedIndex = 0;
                break;
            default://sky
                _selectedIndex = 8;
                break;
        }
        RCC.SpawnRCC (RCC_DemoVehicles.Instance.vehicles [_selectedIndex], transform.position, transform.rotation, true, true, true);
		
	}

}
