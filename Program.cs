// See https://aka.ms/new-console-template for more informat
using System.Security;

int[] n={20,40,30,50,60};
int sub=n[0];
for(int i=0;i<n.Length;i++){
    sub=sub-n[i];

}
Console.WriteLine(sub);
