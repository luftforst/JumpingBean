using UnityEngine;
using System.Collections;

public class heap : MonoBehaviour {

	int NoN = 8; //Number of Node 전체노드개수
	int[] A = new int[8];


	void Start()
	{
		A [0] = 40;
		A [1] = 80;
		A [2] = 60;
		A [3] = 50;
		A [4] = 30;
		A [5] = 70;
		A [6] = 10;
		A [7] = 20;
		BuildHeap ();
	}


	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Z))
		{
			Debug.Log("press Z");
			DeleteNode();
			BuildHeap ();
		}

		if(Input.GetKeyDown(KeyCode.X))
		{
			Debug.Log("press X");
			InsertNode(99);
			BuildHeap();
		}
	}

	void BuildHeap()
	{
		for(int i = NoN/2 ; i>0 ; i--)
		{
			DownHeap(i);
		}
		
		for(int i = 0 ; i<NoN ; i++)
		{
			Debug.Log(i+1 + "번 노드" + A[i]);
			
		}
	}
	void DownHeap(int i) //i = 노드번호 
	{
		int LeftChild = 2*i;
		int RightChild = 2*i + 1;

		int bigger;

		if( (LeftChild <= NoN) && (A[LeftChild-1] > A[i-1]) )
		{
			bigger = LeftChild;
		}
		else
		{
			bigger = i;
		}

		if( (RightChild <= NoN) && (A[RightChild-1] > A[bigger-1]) )
		{
			bigger = RightChild;
		}

		if(bigger != i)
		{
			swap(ref A[bigger-1],ref A[i-1]);
			DownHeap(bigger);
		}
	}

	void swap(ref int a, ref int b)
	{
		int temp;
		temp = a;
		a = b;
		b = temp;
	}

	void DeleteNode()
	{
		swap (ref A [0], ref A [NoN - 1]);
		NoN--;
	}

	void InsertNode(int nodeValue)
	{
		int parent = (NoN - 1) / 2;
		A [NoN] = nodeValue;
		NoN++;

	}
}
