#include <iostream>
#include <fstream>
using namespace std;
ifstream fin("test.txt");
int n, m, a[100][100], i, j, s;
int main()
        {
            fin >> n >> m;
            for (i = 1; i <= n; i++)
                for (j = 1; j <= m; j++)
                    fin >> a[i][j]; 
for(i=1;i<=n;i++)
for(j=i+1;j<=n;j++)
cout<<a[i][j]<<" "
return 0; }
