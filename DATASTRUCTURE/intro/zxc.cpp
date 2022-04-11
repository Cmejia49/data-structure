#include <iostream>
#include<math.h>
#include<iomanip>
/* run this program using the console pauser or add your own getch, system("pause") or input loop */
using namespace std;
int main(int argc, char** argv) {
	float principle,rate,t,amt,p;
	
	cout<<"Enter the principal";
	cin>>principle;
	cout<<"Enter the rate";
	cin>>rate;
	cout<<"Enter the T";
	cin>>t;
	
	rate =rate / 100;
	p = 1+(rate/t);
	amt = principle * pow(p,t);
	cout<<"Interest"<<fixed<<setprecision(2)<<amt-principle<<endl;
	cout<<"Final"<<fixed<<setprecision(2) << amt;
	
	return 0;
}
