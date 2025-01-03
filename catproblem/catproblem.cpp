

#include <iostream>
#include<vector>
using namespace std;

int func(vector<string>arr)
{
	int output = 0;
	
	for (int i = 0;i < arr.size();i++)
	{
		if (arr[i] == "++")
			output++;
		else if (arr[i]=="--")
		
			output--;
	
		
	}
	return output;
	

}


int main()
{
	
	vector<string>arr;


	int cnt;
	cin >> cnt;
	string input;
	for (int i = 0;i < cnt;i++)
	{
		cin >> input;
		arr.push_back(input);
		
	}
	cout << func(arr);
	
}

