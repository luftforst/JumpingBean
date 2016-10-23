using UnityEngine;
using System.Collections;

public class PlatformSpawn : MonoBehaviour {

	GameObject Spawner1;
	GameObject Spawner2;
	GameObject Spawner3;
	GameObject Player;

	float checkPos = 0;

	GameObject Platform_Random;
	public GameObject Platform_Normal;
	public GameObject Platform_Break;
	public GameObject Platform_Slide;
	public GameObject Platform_Razer;
	public GameObject Platform_Beam;
	public GameObject Item_booster;

	public float min = 0.8f;
	public float max = 2.5f;
		
	void Start()
	{
		Player = GameObject.FindWithTag("Player");
		Spawner1 = GameObject.FindWithTag("Spawner1");
		Spawner2 = GameObject.FindWithTag("Spawner2");
		Spawner3 = GameObject.FindWithTag("Spawner3");
	}

	void Update () {										//spawner의 y좌표가 일정만큼 증가하면  
		Start ();								//1,2,3 랜덤 - > Spawner1,2,3 선택 -> 그 안에서 또 랜덤 -> 플랫폼 종류 선택
		float PlayerPos = Player.transform.position.y;
		int Select_Spawner = Random.Range (1, 4);
		float RandomIncrease = Random.Range (min, max);



		RandomPlatform ();
		if(PlayerPos > checkPos)
		{
			switch(Select_Spawner)
			{
			case 1:
				Instantiate(Platform_Random, Spawner1.transform.position, Spawner1.transform.rotation);
				break;
				
			case 2:
				Instantiate(Platform_Random, Spawner2.transform.position, Spawner2.transform.rotation);
				break;
			
			case 3:
				Instantiate(Platform_Random, Spawner3.transform.position, Spawner3.transform.rotation);
				break;
			}
			checkPos+=RandomIncrease;
		}
		
	}



	void RandomPlatform()
	{
		int Select_Platform = Random.Range (1, 100);
	
		if (1 <= Select_Platform && Select_Platform <= 40)
		{
			Platform_Random = Platform_Normal;
		}

		if (41 <= Select_Platform && Select_Platform <= 60)
		{
			Platform_Random = Platform_Beam;
		}

		if (61 <= Select_Platform && Select_Platform <= 80)
		{
			Platform_Random = Platform_Slide;
		}

		if (81 <= Select_Platform && Select_Platform <= 90)
		{
			Platform_Random = Platform_Razer;
		}

		if (91 <= Select_Platform && Select_Platform <= 95)
		{
			Platform_Random = Platform_Break;
		}

		if (96 <= Select_Platform && Select_Platform <= 99)
		{
			Platform_Random = Item_booster;
		}
	}

	


	






































		/*if(PlayerPos > checkPos)
		{
			int Select_Spawner;
			int SpawnCount = Random.Range(1,3);
			int Select_Platform = Random.Range (1, 1);

			for(int i = 0; i < SpawnCount; i++){
				Select_Spawner = Random.Range(1,4);

				switch(Select_Spawner)
				{
				case 1:
					if(Select_Platform == 1)
					{
						Instantiate(Platform_Normal, Spawner1.transform.position, Spawner1.transform.rotation);
					}
					break;

				case 2:
					if(Select_Platform == 1)
					{
						Instantiate(Platform_Normal, Spawner1.transform.position, Spawner1.transform.rotation);
					}
					break;
				case 3:
					if(Select_Platform == 1)
					{
						Instantiate(Platform_Normal, Spawner1.transform.position, Spawner1.transform.rotation);
					}
					break;
				}
			}
			checkPos+=3.5f;
		}*/
	
/*
			if(Select_Spawner == 1)	//Spawner1
			{
				int Select_Platform = Random.Range (1, 1);
				if(Select_Platform == 1)
				{
					Instantiate(Platform_Normal, Spawner1.transform.position, Spawner1.transform.rotation);
				}
			}

			if(Select_Spawner == 2)	//Spawner2
			{
				int Select_Platform = Random.Range (1, 1);
				if(Select_Platform == 1)
				{
					Instantiate(Platform_Normal, Spawner2.transform.position, Spawner2.transform.rotation);
				}
			}

			if(Select_Spawner == 3)	//Spawner3
			{
				int Select_Platform = Random.Range (1, 1);
				if(Select_Platform == 1)
				{
					Instantiate(Platform_Normal, Spawner3.transform.position, Spawner3.transform.rotation);
				}
			}
			checkPos += 3.5f;
		}
		*/
	


}
