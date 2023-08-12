using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{



    public void AlphaScene()
	{
        int sceneBuildIndex = 0; 
        SceneManager.LoadScene(sceneBuildIndex); 
    }

	public void SpaceshipScene()
	{
        int sceneBuildIndex = 1; 
        SceneManager.LoadScene(sceneBuildIndex); 
    }
	
	
	public void BlueSkyScene()
	{
        int sceneBuildIndex = 2;
        SceneManager.LoadScene(sceneBuildIndex);
    }


	public void AsteroidScene()
	{
        int sceneBuildIndex = 3;
        SceneManager.LoadScene(sceneBuildIndex);
    }

    public void PlanetRocketScene()
	{
        int sceneBuildIndex = 4;
        SceneManager.LoadScene(sceneBuildIndex);
    }

    public void AsterodScene()
	{
        int sceneBuildIndex = 5;
        SceneManager.LoadScene(sceneBuildIndex);
    }

    public void MoonSpaceshipScene()
	{
        int sceneBuildIndex = 6;
        SceneManager.LoadScene(sceneBuildIndex);
    }





}
