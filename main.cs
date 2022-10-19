#include<iostream>
using namespace std;
void fun0(int arr[2][3][4])
{

//displaying the elements of array.

	int count = 0;
	for (int i = 0; i < 2; i++)
	{
		for (int j = 0; j < 3; j++)
		{
			for (int k = 0; k < 4; k++)
			{
				cout <<arr[i][j][k];

				//for finding number of zeroes.

				if (arr[i][j][k] == 0)
				{
					cout << ++count;
				}
			}
		}
	}
	cout << endl;
	cout <<"NUMBER OF ZEROES = "<< count;
}
int main()
{
	int arr[2][3][4] = { {{2,3,0,4},{2,7,0,1},{0,3,5,8}},{{2,3,0,4},{2,7,0,1},{2,3,5,8}} };
	fun0(arr);
	system("pause>0");
}
