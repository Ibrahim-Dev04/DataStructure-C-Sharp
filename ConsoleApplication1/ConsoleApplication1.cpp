// ConsoleApplication1.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;



int FindCharIndex(string S)
{
    int index = -1;

    for (int i = 0; i < S.length(); i++)
    {
        char c = S[i];
        for (int j = i + 1; j < S.length(); j++)
        {
            if (c == S[j])
            {
                index = -1;
                break;
            }
            else
                index = i;

            if (j == S.length() - 1)
                return index;

        }
    }
}
int main()
{
    string S = "hemllowohrld";

    cout << "first non repeating char index is = " << FindCharIndex(S) << endl;
    return 0;
}