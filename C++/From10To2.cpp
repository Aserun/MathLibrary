#include <iostream>
#include <stdio.h>
#include <time.h>
using namespace std;
//10�i�@����2�i�@�ɂ���A���S���Y��
void From10To2(int n)
{
	int sinhou[100];
	int count = 0;

	while (true)
	{
		int i = n / 2;
		if (n % 2 == 0)
		{
			//����؂ꂽ��0������
			sinhou[count] = 0;
			count++;
		}
		else {
			//����؂�Ȃ�������1������
			sinhou[count] = 1;
			count++;
		}
		n = i;
		if (n == 1)
		{
			sinhou[count] = 1;
			count++;
			break;
		}
		else if (n == 0)
		{
			sinhou[count] = 0;
			count++;
			break;
		}
	}
	string str = "";
	for (int i = count - 1; i >= 0; i--)
	{
		cout << sinhou[i];
	}
	cout << endl;
}
inline void InitRand()
{
	srand((unsigned int)time(NULL));
}

int main()
{
	InitRand();
	int n = rand() % 100 + 1;
	int s;
	cout << n << "��2�i���́H:�����L�[����͂����瓚���������܂��B" << endl;
	cin >> s;
	From10To2(n);
	cin >> n;
	return 0;
}

