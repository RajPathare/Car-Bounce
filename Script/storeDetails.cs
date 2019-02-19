using System.Runtime.Serialization.Formatters;
using UnityEngine;
using UnityEngine.UI;

public class storeDetails : MonoBehaviour{

	
	public static int skinId;
	[SerializeField]private int coinCount;
	[SerializeField]private int []buyDetails = new int[8];
	public Text[] texts;
	
	private void Start()
	{
		if(!PlayerPrefs.HasKey("buyCar0"))
			PlayerPrefs.SetInt("buyCar0",2);
		
		coinCount = PlayerPrefs.GetInt("coinCount");
		
		buyDetails[0] = PlayerPrefs.GetInt("buyCar0");
		buyDetails[1] = PlayerPrefs.GetInt("buyCar1");
		buyDetails[2] = PlayerPrefs.GetInt("buyCar2");
		buyDetails[3] = PlayerPrefs.GetInt("buyCar3");
		buyDetails[4] = PlayerPrefs.GetInt("buyCar4");
		buyDetails[5] = PlayerPrefs.GetInt("buyCar5");
		buyDetails[6] = PlayerPrefs.GetInt("buyCar6");
		buyDetails[7] = PlayerPrefs.GetInt("buyCar7");

		for (int i = 0; i < texts.Length; i++)
		{
			if (buyDetails[i] == 0)
			{
				texts[i].text = "Buy";
			}
			else if (buyDetails[i] == 1)
			{
				texts[i].text = "Use";
			}
			else if (buyDetails[i] == 2)
			{
				texts[i].text = "Using";
			}
		}
		
		
		skinId = PlayerPrefs.GetInt("skinId");
		
		
		Debug.Log("Store Script launched");
		
	}

	

	public  void skinSelect(int id)
	{
		if (id == 0)
		{
			skinId = id;
			setActive(id);
			texts[0].text = "Using";
		}
		else if (id == 1 )
		{
			if (buyDetails[1] == 0 && coinCount >= 20)
			{
				coinCount -= 20;
				skinId = id;
				PlayerPrefs.SetInt("coinCount", coinCount);
				setActive(id);
				texts[1].text = "Using";
			}

			if (buyDetails[1] == 1)
			{
				buyDetails[1] = 2;
				setActive(id);
				texts[1].text = "Using";
			}
			
		}
		else if (id == 2 )
		{
			if (buyDetails[2] == 0&& coinCount >= 50)
			{
				coinCount -= 50;
				skinId = id;
				PlayerPrefs.SetInt("coinCount", coinCount);
				setActive(id);
				texts[2].text = "Using";
			}

			if (buyDetails[2] == 1)
			{
				buyDetails[2] = 2;
				setActive(id);
				texts[2].text = "Using";
			}
		}
		else if (id == 3 )
		{
			if (buyDetails[3] == 0&& coinCount >= 100)
			{
				coinCount -= 100;
				skinId = id;
				PlayerPrefs.SetInt("coinCount", coinCount);
				setActive(id);
				texts[3].text = "Using";
			}

			if (buyDetails[3] == 1)
			{
				buyDetails[3] = 2;
				setActive(id);
				texts[3].text = "Using";
			}
		}
		else if (id == 4 )
		{
			if (buyDetails[4] == 0&& coinCount >= 250)
			{
				coinCount -= 250;
				skinId = id;
				PlayerPrefs.SetInt("coinCount", coinCount);
				setActive(id);
				texts[4].text = "Using";
			}

			if (buyDetails[4] == 1)
			{
				buyDetails[4] = 2;
				setActive(id);
				texts[4].text = "Using";
			}
		}
		else if (id == 5 )
		{
			if (buyDetails[5] == 0&& coinCount >= 300)
			{
				coinCount -= 300;
				skinId = id;
				PlayerPrefs.SetInt("coinCount", coinCount);
				setActive(id);
				texts[5].text = "Using";
			}

			if (buyDetails[5] == 1)
			{
				buyDetails[5] = 2;
				setActive(id);
				texts[5].text = "Using";
			}
		}
		else if (id == 6 )
		{
			if (buyDetails[6] ==0 && coinCount >= 400)
			{
				coinCount -= 400;
				skinId = id;
				PlayerPrefs.SetInt("coinCount", coinCount);
				setActive(id);
				texts[6].text = "Using";
			}

			if (buyDetails[6] == 1)
			{
				buyDetails[6] = 2;
				setActive(id);
				texts[6].text = "Using";
			}
		}
		else if (id == 7 )
		{
			if (buyDetails[7] == 0 && coinCount >= 500)
			{
				coinCount -= 500;
				skinId = id;
				PlayerPrefs.SetInt("coinCount", coinCount);
				setActive(id);
				texts[7].text = "Using";
			}

			if (buyDetails[7] == 1)
			{
				buyDetails[7] = 2;
				setActive(id);
				texts[7].text = "Using";
			}
		}
		
		
		PlayerPrefs.SetInt("buyCar0",buyDetails[0]);
		PlayerPrefs.SetInt("buyCar1",buyDetails[1]);
		PlayerPrefs.SetInt("buyCar2",buyDetails[2]);
		PlayerPrefs.SetInt("buyCar3",buyDetails[3]);
		PlayerPrefs.SetInt("buyCar4",buyDetails[4]);
		PlayerPrefs.SetInt("buyCar5",buyDetails[5]);
		PlayerPrefs.SetInt("buyCar6",buyDetails[6]);
		PlayerPrefs.SetInt("buyCar7",buyDetails[7]);
		
		
		
		PlayerPrefs.SetInt("skinId",skinId);
		
	}

	public void setActive(int id)
	{
		for (int i = 0; i < buyDetails.Length; i++)
		{
			if (i != id && buyDetails[i] == 2)
			{
				buyDetails[i] = 1;
				texts[i].text = "Use";
			}
			else if (i == id)
			{
				buyDetails[i] = 2;
				texts[i].text = "Using";
			}
		}
	
		skinId = id;
		PlayerPrefs.SetInt("skinId",id);
	}

	int getSkinId()
	{
		return skinId;
	}
	
}
